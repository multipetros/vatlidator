﻿#region about this file
/* AboutForm class, this is part of Vatlidator program
 * Copyright (c) 2011-2014, Petros Kyladitis
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
using System.Drawing;
using System.Windows.Forms;
using System.IO ;
using System.Diagnostics;

namespace Vatlidator{
	/// <summary>
	///
	/// </summary>
	public partial class AboutForm : Form{
		
		/// <summary>
		/// 
		/// </summary>
		public AboutForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void AboutFormLoad(object sender, EventArgs e){
			//try to read license from the file and load the text the textbox.
			try{
				textBoxLiscense.Text += File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\License.txt") ;
			}catch(Exception){ /* do nothing */ }
			
			//add linkData to the linkLabel
			LinkLabel.Link link = new LinkLabel.Link() ;
			link.LinkData = "http://www.multipetros.gr/" ;
			linkLabelMultipetros.Links.Add(link) ;
		}
		
		void ButtonOKClick(object sender, EventArgs e){
			this.DialogResult = DialogResult.OK ;
		}
		
		void LinkLabelMultipetrosLinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
			//open the default browser and navigate to the home page
			Process.Start(e.Link.LinkData.ToString()) ;
		}
	}
}
