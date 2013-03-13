#region about this file
/* MainForm.Designer class, this is part of Vatlidator program
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
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonDownloadInfo = new System.Windows.Forms.Button();
			this.pictureBoxInsert = new System.Windows.Forms.PictureBox();
			this.labelValidation = new System.Windows.Forms.Label();
			this.pictureBoxValid = new System.Windows.Forms.PictureBox();
			this.pictureBoxInvalid = new System.Windows.Forms.PictureBox();
			this.textBoxVat = new System.Windows.Forms.TextBox();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxValid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).BeginInit();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.MinimumSize = new System.Drawing.Size(200, 115);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.buttonDownloadInfo);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxInsert);
			this.splitContainer.Panel1.Controls.Add(this.labelValidation);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxValid);
			this.splitContainer.Panel1.Controls.Add(this.pictureBoxInvalid);
			this.splitContainer.Panel1.Controls.Add(this.textBoxVat);
			this.splitContainer.Panel1.Controls.Add(this.menuStripMain);
			this.splitContainer.Panel1MinSize = 0;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.webBrowser);
			this.splitContainer.Panel2MinSize = 0;
			this.splitContainer.Size = new System.Drawing.Size(230, 115);
			this.splitContainer.SplitterDistance = 103;
			this.splitContainer.TabIndex = 8;
			// 
			// buttonDownloadInfo
			// 
			this.buttonDownloadInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonDownloadInfo.Image")));
			this.buttonDownloadInfo.Location = new System.Drawing.Point(179, 65);
			this.buttonDownloadInfo.Name = "buttonDownloadInfo";
			this.buttonDownloadInfo.Size = new System.Drawing.Size(39, 30);
			this.buttonDownloadInfo.TabIndex = 8;
			this.buttonDownloadInfo.UseVisualStyleBackColor = true;
			this.buttonDownloadInfo.Click += new System.EventHandler(this.ButtonDownloadInfoClick);
			// 
			// pictureBoxInsert
			// 
			this.pictureBoxInsert.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInsert.Image")));
			this.pictureBoxInsert.Location = new System.Drawing.Point(12, 27);
			this.pictureBoxInsert.Name = "pictureBoxInsert";
			this.pictureBoxInsert.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxInsert.TabIndex = 6;
			this.pictureBoxInsert.TabStop = false;
			// 
			// labelValidation
			// 
			this.labelValidation.AutoSize = true;
			this.labelValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelValidation.Location = new System.Drawing.Point(46, 34);
			this.labelValidation.Name = "labelValidation";
			this.labelValidation.Size = new System.Drawing.Size(150, 25);
			this.labelValidation.TabIndex = 0;
			this.labelValidation.Text = "Εισάγετε ΑΦΜ";
			this.labelValidation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxValid
			// 
			this.pictureBoxValid.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxValid.Image")));
			this.pictureBoxValid.Location = new System.Drawing.Point(12, 27);
			this.pictureBoxValid.Name = "pictureBoxValid";
			this.pictureBoxValid.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxValid.TabIndex = 3;
			this.pictureBoxValid.TabStop = false;
			this.pictureBoxValid.Visible = false;
			// 
			// pictureBoxInvalid
			// 
			this.pictureBoxInvalid.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInvalid.Image")));
			this.pictureBoxInvalid.Location = new System.Drawing.Point(12, 27);
			this.pictureBoxInvalid.Name = "pictureBoxInvalid";
			this.pictureBoxInvalid.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxInvalid.TabIndex = 2;
			this.pictureBoxInvalid.TabStop = false;
			this.pictureBoxInvalid.Visible = false;
			// 
			// textBoxVat
			// 
			this.textBoxVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.textBoxVat.Location = new System.Drawing.Point(12, 65);
			this.textBoxVat.MaxLength = 9;
			this.textBoxVat.Name = "textBoxVat";
			this.textBoxVat.Size = new System.Drawing.Size(161, 30);
			this.textBoxVat.TabIndex = 1;
			this.textBoxVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxVat.TextChanged += new System.EventHandler(this.TextBoxVatTextChanged);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem,
									this.hideToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.ShowItemToolTips = true;
			this.menuStripMain.Size = new System.Drawing.Size(230, 24);
			this.menuStripMain.TabIndex = 7;
			this.menuStripMain.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.fileToolStripMenuItem.Text = "&Αρχείο";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.exitToolStripMenuItem.Text = "Έ&ξοδος";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.helpToolStripMenuItem.Text = "&Βοήθεια";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.aboutToolStripMenuItem.Text = "&Πληροφορίες";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// hideToolStripMenuItem
			// 
			this.hideToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.hideToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hideToolStripMenuItem.Image")));
			this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
			this.hideToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
			this.hideToolStripMenuItem.ToolTipText = "Απόκρυψη επιπλέον πληροφοριών";
			this.hideToolStripMenuItem.Click += new System.EventHandler(this.HideToolStripMenuItemClick);
			// 
			// webBrowser
			// 
			this.webBrowser.AllowWebBrowserDrop = false;
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(0, 0);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(230, 8);
			this.webBrowser.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonDownloadInfo;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(230, 107);
			this.Controls.Add(this.splitContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(236, 135);
			this.Name = "MainForm";
			this.Text = "Vatlidator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxValid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvalid)).EndInit();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.Button buttonDownloadInfo;
		private System.Windows.Forms.PictureBox pictureBoxInsert;
		private System.Windows.Forms.PictureBox pictureBoxValid;
		private System.Windows.Forms.PictureBox pictureBoxInvalid;
		private System.Windows.Forms.Label labelValidation;
		private System.Windows.Forms.TextBox textBoxVat;
	}
}
