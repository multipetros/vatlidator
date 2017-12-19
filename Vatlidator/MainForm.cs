/* Vatlidator: Main form
 * (c) 2011-2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Text.RegularExpressions;
using Multipetros.Config;

namespace Vatlidator{
	/// <summary>
	/// MainForm of Vatlidator tool
	/// </summary>
	public partial class MainForm : Form{
		
		ResourceManager resmgr ;
		CultureInfo ci ;
		Vies vies = new Vies() ;
		RegistryIni ini = new RegistryIni(Application.CompanyName, Application.ProductName) ;
		
		public MainForm(){
			InitializeComponent();
			resmgr = new ResourceManager(typeof(MainForm)) ;
			comboBoxCountry.Items.AddRange(vies.SupportedCountries) ;
			LoadRes() ;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			ci = new CultureInfo((ini["lang"].Length > 0) ? ini["lang"] : "en") ;
			LoadRes() ;
			
			int countryIndex ;
			int.TryParse(ini["country"], out countryIndex) ;
			comboBoxCountry.SelectedIndex = countryIndex ;
			
			int left ;
			int.TryParse(ini["left"], out left) ;
			this.Left = left > 0 ? left : 100 ;
			
			int top ;
			int.TryParse(ini["top"], out top) ;
			this.Top = top > 0 ? top : 100 ;
		}
		
		private string GetRes(string key){
			return resmgr.GetString(key, ci) ;
		}
		
		private void LoadRes(){
			labelAddress.Text = GetRes("LabelAddress") ;
			labelName.Text = GetRes("LabelName") ;
			buttonValidate.Text = GetRes("ButtonValidate") ;
			exitToolStripMenuItem.Text = GetRes("MenuExit") ;
			fileToolStripMenuItem.Text = GetRes("MenuFile") ;
			languageToolStripMenuItem.Text = GetRes("MenuLanguage") ;
			aboutToolStripMenuItem.Text = GetRes("MenuAbout") ;
		}
		
		void ButtonValidateClick(object sender, EventArgs e){
			textBoxVatID.Text = textBoxVatID.Text.ToUpper() ;
			textBoxVatID.Text = Regex.Replace(textBoxVatID.Text, "[^0-9A-Z]", "") ;
			if(textBoxVatID.Text.Length >0){
				try{		
					buttonValidate.Text = GetRes("ButtonWait") ;
					buttonValidate.Enabled = false ;
					vies = vies.Validate(comboBoxCountry.SelectedItem.ToString(), textBoxVatID.Text) ;
					labelValid.Text =  GetRes(vies.Valid ? "LabelValidTrue" : "LabelValidFalse") ;
					labelValid.BackColor = vies.Valid ? Color.Green : Color.Red ;
					textBoxName.Text = vies.Name ;
					textBoxAddress.Text = vies.Address ;
				}catch(Exception err){
					MessageBox.Show(err.Message, GetRes("ErrorAtValidation"), MessageBoxButtons.OK, MessageBoxIcon.Error) ;
					labelValid.Text = "" ;
					labelValid.BackColor = SystemColors.Control ;
					textBoxName.Text = "" ;
					textBoxAddress.Text = "" ;
				}finally{
					buttonValidate.Text = GetRes("ButtonValidate") ;
					buttonValidate.Enabled = true ;
				}				
			}else{
				MessageBox.Show(GetRes("ErrorNoInput"), GetRes("ErrorBeforeValidation"), MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void EnglishToolStripMenuItemClick(object sender, EventArgs e){
			ci = new CultureInfo("en") ;
			LoadRes() ;
			ini["lang"] = "en" ;
		}
		
		void GreekToolStripMenuItemClick(object sender, EventArgs e){
			ci = new CultureInfo("el") ;
			LoadRes() ;
			ini["lang"] = "el" ;
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e){
			ini["country"] = comboBoxCountry.SelectedIndex.ToString() ;
			ini["left"] = this.Left.ToString() ;
			ini["top"] = this.Top.ToString() ;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show(GetRes("AboutMsg"), GetRes("AboutTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
	}
}
