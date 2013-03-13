#region about this file
/* MainForm class, this is part of Vatlidator program
 * Copyright (c) 2011-2013, Petros Kyladitis
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version. 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details. 
 * You should see a copy of the GNU General Public License
 * above.  If not, see <http://www.gnu.org/licenses/>
 */
 #endregion
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO ;
using Multipetros.Validation ;
using Multipetros.WebServices ;

namespace Vatlidator{
	/// <summary>
	/// 
	/// </summary>
	public partial class MainForm : Form{
		
		/// <summary>
		/// 
		/// </summary>
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		private readonly string HTML_FILENAME = "vatlidator.html" ;
		private readonly string CSS_FILENAME = "vatlidator.css" ;
		private readonly string JQUERY_FILENAME = "jquery-1.9.1.min.js" ;
		private string previousVatin ; //store the previous vatin, to avoid re-download data if is the same
		private string htmlFilePath ; //this initialize at the FormLoad event. If can't write setted to null.
		private string htmlHeader = "<!doctype html><html lang=\"el\"><head><meta charset=\"utf-8\"><link rel=\"stylesheet\" type=\"text/css\" href=\"vatlidator.css\"><script src=\"jquery-1.9.1.min.js\"></script><title></title></head><body>" ;
		private string htmlFooter = "<script>$(document).ready(function(){$(\"tr:even\").css(\"background-color\", \"rgb(221, 238, 255)\");});</script></body></html>" ;		

		//inspect and validate text when inserted
		void TextBoxVatTextChanged(object sender, EventArgs e){
			int viesVatId ;
			if(textBoxVat.Text.Length!=9 || !int.TryParse(textBoxVat.Text, out viesVatId)){
				labelValidation.Text = "Εισάγετε ΑΦΜ" ;
				labelValidation.ForeColor = Color.Black ;
				pictureBoxValid.Visible =  false ;
				pictureBoxInvalid.Visible = false ;
				pictureBoxInsert.Visible = true ;
				return ;
			}
			if(ViesGr.IsValid(viesVatId)){
				labelValidation.Text = "Έγκυρο" ;
				labelValidation.ForeColor = Color.Green ;
				pictureBoxValid.Visible =  true ;
				pictureBoxInvalid.Visible = false ;
				pictureBoxInsert.Visible = false ;
			}
			else{
				labelValidation.Text = "Άκυρο" ;
				labelValidation.ForeColor = Color.Red ;
				pictureBoxValid.Visible = false ;
				pictureBoxInvalid.Visible = true ;
				pictureBoxInsert.Visible = false ;
			}
		}
		
		//show the AboutForm dialog
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			Form about = new AboutForm() ;
			DialogResult result = about.ShowDialog() ;
		}
		
		void ButtonDownloadInfoClick(object sender, EventArgs e){
			//if vatin is not valid (see if pictureBoxValid is visible to avoid string parsing and validation)
			//inform user that can't continue and exit
			if(pictureBoxValid.Visible == false){
				MessageBox.Show("Το ΑΦΜ που έχετε εισάγει δεν είναι έγκυρο! Πρέπει να εισάγετε ένα έγκυρο ΑΦΜ για να μπορέσουν να ληφθούν πληροφορίες γι' αυτό από τη βάση δεδομένων της ΓΓΠΣ","Δεν είναι δυνατή η λήψη πληροφοριών!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return ;
			}

			//if htmlFilePath is null, means that can't write to user temp or app dir so, inform user and exit
			if(htmlFilePath == null){
				MessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα εγγραφής στον προσωρινό φάκελο του συστήματος, ή στον φάκελο που έχετε εγκατεστημένη την εφαρμογή, ώστε να μπορέσουν να δημιουργηθούν τα απαραίτητα αρχεία. Επικοινωνήστε με το διαχειριστή του συστήματός σας για να επιλύσετε αυτό το πρόβλημα.", "Αδυναμία εγγραφής δεδομένων", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return ;
			}
			
			//if MainForm window is in compact mode, trasform it to full view (sizable, maximize button enabled
			//reveal browser by expanding window to 640x480 and show the hideToolStripMenuItem)
			if(this.MaximizeBox == false){
				hideToolStripMenuItem.Visible = true ;
				this.MaximizeBox = true ;
				this.FormBorderStyle = FormBorderStyle.Sizable ;
				this.Width = 640 ; 
				this.Height = 480 ;				
			}
			
			//if current vatin is the same with the previous one exit, else download data
			if(previousVatin == textBoxVat.Text)
				return ;
			else
				previousVatin = textBoxVat.Text ;
			
			//create new AfmInfo object, download data, make an html file and present it to user
			//on any exception, create html file with the exception's message
			AfmInfo vatin ;
			try{
				vatin = new AfmInfo(textBoxVat.Text) ;
				File.WriteAllText(htmlFilePath, CreatePage(vatin)) ;
				webBrowser.Navigate(htmlFilePath) ;
			}catch(Exception exc){
				File.WriteAllText(htmlFilePath, CreatePage("<div style=\"color: red;\">" + exc.Message + "</div>")) ;
				webBrowser.Navigate(htmlFilePath) ;
			}
			
		}
		
		//return MainForm window to compact mode (hide browser, fixed form, disable maximize button) and hide hideToolStripMenuItem
		void HideToolStripMenuItemClick(object sender, EventArgs e)	{
			this.MaximizeBox = false ;
			this.FormBorderStyle = FormBorderStyle.FixedSingle ;
			hideToolStripMenuItem.Visible = false ;
			this.Width = 236 ; 
			this.Height = 135 ;
		}
		
		//terminate the application
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		//create the htmlpage from AfmInfo object data
		private string CreatePage(AfmInfo vatin){
			string html = htmlHeader + "<table cellpading=\"4\" cellspacing=\"4\">" ;
			
			string title = vatin.Afm ;
			if(vatin.DeactivationFlag != null && vatin.DeactivationFlag == "1"){
				if(vatin.DeactivationFlagDescr != null)
					title += " - " + vatin.DeactivationFlagDescr ;
			}
			else{
				if(vatin.DeactivationFlagDescr != null)
					title += " - <span style=\"color: red\">" + vatin.DeactivationFlagDescr + "</span>" ;
			}
			if(vatin.FirmFlagDescr != null){
				if(vatin.FirmFlagDescr.Contains("ΠΡΩΗΝ"))
					title +=  " - <span style=\"color: red\">" + vatin.FirmFlagDescr + "</span>" ;
				else
					title += " - " + vatin.FirmFlagDescr ;
			}
			html += AddRow("ΑΦΜ", title) ;
			
			if(vatin.AssTxpActualAfm != null)
				html += AddRow("Μεταφορά από", vatin.AssTxpActualAfm) ;
			
			if(vatin.Onomasia != null)
				html += AddRow("Επωνυμία", vatin.Onomasia) ;
			
			if(vatin.CommerTitle != null)
				html += AddRow("Εμπορικός τίτλος", vatin.CommerTitle) ;
			
			if(vatin.LegalStatusDescr != null)
				html += AddRow("Νομική Μορφή", vatin.LegalStatusDescr) ;
			else
				html += AddRow("Μορφή", "ΦΥΣΙΚΟ ΠΡΟΣΩΠΟ") ;
			
			string act = null;
			if(vatin.ActLongDescr != null)
				act = vatin.ActLongDescr ;
			
			if(act != null){
				if(vatin.FacActivity != null)
					act += " - (ΚΩΔ " + vatin.FacActivity + ")" ;
			}
			else{
				if(vatin.FacActivity != null)
					act = "ΚΩΔ " + vatin.FacActivity ;
			}
			if(act != null)
				html += AddRow("Κύρια δραστηριότητα", act) ;
			
			string addr = null ;
			if(vatin.PostalAddress != null)
				addr = vatin.PostalAddress ;
			if(addr != null){
				if(vatin.PostalAddressNo != null)
					addr += " " + vatin.PostalAddressNo ;
			}
			else{
				if(vatin.PostalAddressNo != null)
					addr = vatin.PostalAddressNo ;
			}
			if(addr != null){
				if(vatin.PostalZipCode != null)
					addr += " - " + vatin.PostalZipCode ;
			}
			else{
				if(vatin.PostalZipCode != null)
					addr = vatin.PostalZipCode ;
			}
			if(addr != null){
				if(vatin.ParDescription != null)
					addr += " " + vatin.ParDescription ;
			}
			else{
				if(vatin.ParDescription != null)
					addr = vatin.ParDescription ;
			}
			if(addr != null)
				html += AddRow("Έδρα", addr) ;

			if(vatin.CountOfBranches != null && vatin.CountOfBranches != 0)
				html += AddRow("Υποκαταστήματα", vatin.CountOfBranches.ToString()) ;
			
			if(vatin.FirmPhone != null)
				html += AddRow("Τηλέφωνο", vatin.FirmPhone) ;
			
			if(vatin.FirmFax != null)
				html += AddRow("ΦΑΞ", vatin.FirmFax) ;
			
			string doy = null;
			if(vatin.Doy != null)
				doy = vatin.Doy ;
			if(doy != null){
				if(vatin.DoyDescr != null)
					doy += " - " + vatin.DoyDescr ;
			}
			else{
				if(vatin.DoyDescr != null)
					doy = vatin.DoyDescr ;
			}
			if(doy != null)
				html += AddRow("ΔΟΥ", doy) ;
			
			string residence = null ;
			if(vatin.ResidenceZipCode != null)
				residence = vatin.ResidenceZipCode ;
			if(residence != null){
			   	if(vatin.ResidenceParDescription != null){
				   	residence += " " + vatin.ResidenceParDescription ;
			   	}
			}
			else{
				if(vatin.ResidenceParDescription != null){
				   	residence = vatin.ResidenceParDescription ;
			   	}
			}
			if(residence != null)
				html += AddRow("Περιοχή επιτηδευματία", vatin.ResidenceZipCode + " " + vatin.ResidenceParDescription) ;
			
			if(vatin.RegistDate != null)
				html += AddRow("Ημ/νία έναρξης", vatin.RegistDate.ToString()) ;
			
			if(vatin.StopDate != null)
				html += AddRow("Ημ/νία διακοπής", vatin.StopDate.ToString()) ;
			
			html += "</table>" + htmlFooter ;
			return html ;
		}
		
		//create html page contains the message arg
		private string CreatePage(string message){
			string html = htmlHeader + message + htmlFooter ;
			return html ;
		}
		
		//create an html table row with 2 columns
		private string AddRow(string col1, string col2){
			return "<tr><td>" + col1 + "</td><td>" + col2 + "</td>" ;
		}	
		
		//when MainFormLoad search for writable paths and initialize tooltips
		void MainFormLoad(object sender, EventArgs e){
			//set html file path to temp folder and try to create it. On success copy the css and js files there
			//on error, try to create it on app folder. On error set path to null to handle it later
			string appDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\" ;
			htmlFilePath = Path.GetTempPath() + HTML_FILENAME ;
			try{
				File.WriteAllText(htmlFilePath, "") ;
				File.Copy(appDir + CSS_FILENAME,  Path.GetTempPath() + CSS_FILENAME, true) ;
				File.Copy(appDir + JQUERY_FILENAME, Path.GetTempPath() + JQUERY_FILENAME, true) ;
			}catch(Exception){
				try{
					File.WriteAllText(HTML_FILENAME, "") ;
					htmlFilePath = appDir + HTML_FILENAME ;
				}catch(Exception){
					//if can't write anywere, set the htmlFilename to null to handle, when need to write the file
					htmlFilePath = null ;
				}
			}
			
			//hideToolStripMenuItem is hidden when starts
			hideToolStripMenuItem.Visible = false ;
			
			//set tooltips
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(textBoxVat, "Εισάγετε τον αριθμό του ΑΦΜ, για να ελέγξετε την εγκυρότητά του.\nΓια πληροφορίες κατόχου πατήστε enter ή το κουμπί στα δεξιά") ;
			tip.SetToolTip(buttonDownloadInfo, "Λήψη πληροφοριών για τον κάτοχο του ΑΦΜ, από τη βάση δεδομένων της ΓΓΠΣ,\n(στην περίπτωση που αυτός είναι επιτηδευματίας ή νομικό πρόσωπο).") ;
		}
	}
}