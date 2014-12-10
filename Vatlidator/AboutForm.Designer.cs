#region about this file
/* AboutForm.Designer class, this is part of Vatlidator program
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
 
namespace Vatlidator
{
	partial class AboutForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelAbout = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textBoxLiscense = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.labelCredits = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabelMultipetros = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// labelAbout
			// 
			this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelAbout.Location = new System.Drawing.Point(118, 13);
			this.labelAbout.Name = "labelAbout";
			this.labelAbout.Size = new System.Drawing.Size(328, 41);
			this.labelAbout.TabIndex = 1;
			this.labelAbout.Text = "Vatlidator - Έκδοση 2.1\r\nCopyright (c) 2011 - 2014, Petros Kyladitis";
			this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelInfo
			// 
			this.labelInfo.Location = new System.Drawing.Point(16, 135);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(430, 139);
			this.labelInfo.TabIndex = 2;
			this.labelInfo.Text = resources.GetString("labelInfo.Text");
			// 
			// textBoxLiscense
			// 
			this.textBoxLiscense.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxLiscense.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLiscense.Location = new System.Drawing.Point(16, 277);
			this.textBoxLiscense.Multiline = true;
			this.textBoxLiscense.Name = "textBoxLiscense";
			this.textBoxLiscense.ReadOnly = true;
			this.textBoxLiscense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLiscense.Size = new System.Drawing.Size(428, 105);
			this.textBoxLiscense.TabIndex = 3;
			this.textBoxLiscense.TabStop = false;
			this.textBoxLiscense.Text = resources.GetString("textBoxLiscense.Text");
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(350, 400);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(96, 24);
			this.buttonOK.TabIndex = 5;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOKClick);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(15, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(429, 1);
			this.label1.TabIndex = 6;
			this.label1.Text = "label1";
			// 
			// labelCredits
			// 
			this.labelCredits.Location = new System.Drawing.Point(117, 71);
			this.labelCredits.Name = "labelCredits";
			this.labelCredits.Size = new System.Drawing.Size(329, 41);
			this.labelCredits.TabIndex = 7;
			this.labelCredits.Text = "Beta testing Leonidas Kyladitis\r\nIcon art by David Vignoni";
			this.labelCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(17, 388);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(429, 1);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// linkLabelMultipetros
			// 
			this.linkLabelMultipetros.Location = new System.Drawing.Point(118, 54);
			this.linkLabelMultipetros.Name = "linkLabelMultipetros";
			this.linkLabelMultipetros.Size = new System.Drawing.Size(326, 17);
			this.linkLabelMultipetros.TabIndex = 9;
			this.linkLabelMultipetros.TabStop = true;
			this.linkLabelMultipetros.Text = "http://www.multipetros.gr/";
			this.linkLabelMultipetros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMultipetrosLinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(464, 437);
			this.Controls.Add(this.linkLabelMultipetros);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelCredits);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBoxLiscense);
			this.Controls.Add(this.labelInfo);
			this.Controls.Add(this.labelAbout);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Σχετικά με το Vatlidator...";
			this.Load += new System.EventHandler(this.AboutFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.LinkLabel linkLabelMultipetros;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelCredits;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox textBoxLiscense;
		private System.Windows.Forms.Label labelAbout;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
