/* Vatlidator: Main form - Designer class
 * (c) 2011-2017, Petros Kyladitis <http://www.multipetros.gr>
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/> 
 */
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
			this.comboBoxCountry = new System.Windows.Forms.ComboBox();
			this.textBoxVatID = new System.Windows.Forms.TextBox();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonValidate = new System.Windows.Forms.Button();
			this.labelLine = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelAddress = new System.Windows.Forms.Label();
			this.labelValid = new System.Windows.Forms.Label();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxCountry
			// 
			this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCountry.FormattingEnabled = true;
			this.comboBoxCountry.Location = new System.Drawing.Point(11, 38);
			this.comboBoxCountry.Name = "comboBoxCountry";
			this.comboBoxCountry.Size = new System.Drawing.Size(48, 21);
			this.comboBoxCountry.TabIndex = 0;
			// 
			// textBoxVatID
			// 
			this.textBoxVatID.Location = new System.Drawing.Point(65, 38);
			this.textBoxVatID.Name = "textBoxVatID";
			this.textBoxVatID.Size = new System.Drawing.Size(112, 20);
			this.textBoxVatID.TabIndex = 1;
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.languageToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(273, 24);
			this.menuStripMain.TabIndex = 2;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "file";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.exitToolStripMenuItem.Text = "exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.englishToolStripMenuItem,
									this.greekToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.languageToolStripMenuItem.Text = "language";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("englishToolStripMenuItem.Image")));
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.englishToolStripMenuItem.Text = "E&nglish";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItemClick);
			// 
			// greekToolStripMenuItem
			// 
			this.greekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("greekToolStripMenuItem.Image")));
			this.greekToolStripMenuItem.Name = "greekToolStripMenuItem";
			this.greekToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.greekToolStripMenuItem.Text = "Ε&λληνικά";
			this.greekToolStripMenuItem.Click += new System.EventHandler(this.GreekToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.aboutToolStripMenuItem.Text = "about";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// buttonValidate
			// 
			this.buttonValidate.Location = new System.Drawing.Point(183, 36);
			this.buttonValidate.Name = "buttonValidate";
			this.buttonValidate.Size = new System.Drawing.Size(75, 23);
			this.buttonValidate.TabIndex = 2;
			this.buttonValidate.UseVisualStyleBackColor = true;
			this.buttonValidate.Click += new System.EventHandler(this.ButtonValidateClick);
			// 
			// labelLine
			// 
			this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLine.Location = new System.Drawing.Point(12, 76);
			this.labelLine.Name = "labelLine";
			this.labelLine.Size = new System.Drawing.Size(244, 3);
			this.labelLine.TabIndex = 5;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(92, 119);
			this.textBoxName.Multiline = true;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxName.Size = new System.Drawing.Size(162, 50);
			this.textBoxName.TabIndex = 3;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(92, 179);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.ReadOnly = true;
			this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxAddress.Size = new System.Drawing.Size(162, 50);
			this.textBoxAddress.TabIndex = 4;
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(14, 116);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(72, 23);
			this.labelName.TabIndex = 6;
			// 
			// labelAddress
			// 
			this.labelAddress.Location = new System.Drawing.Point(14, 176);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(72, 23);
			this.labelAddress.TabIndex = 7;
			// 
			// labelValid
			// 
			this.labelValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelValid.ForeColor = System.Drawing.Color.White;
			this.labelValid.Location = new System.Drawing.Point(14, 89);
			this.labelValid.Name = "labelValid";
			this.labelValid.Size = new System.Drawing.Size(240, 23);
			this.labelValid.TabIndex = 9;
			this.labelValid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AcceptButton = this.buttonValidate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 242);
			this.Controls.Add(this.labelValid);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelLine);
			this.Controls.Add(this.buttonValidate);
			this.Controls.Add(this.textBoxVatID);
			this.Controls.Add(this.comboBoxCountry);
			this.Controls.Add(this.menuStripMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Vatlidator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greekToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.TextBox textBoxVatID;
		private System.Windows.Forms.Button buttonValidate;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.Label labelValid;
		private System.Windows.Forms.Label labelLine;
		private System.Windows.Forms.ComboBox comboBoxCountry;
	}
}
