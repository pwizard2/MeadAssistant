/*
 * Created by SharpDevelop.
 * User: Will Kraft
 * Date: 10/22/2016
 * Time: 10:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TOSNACalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private TOSNACalculator.Fortifier fortifier1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabFortify;
		private MeadAssistant.TOSNA tosna1;
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tosna1 = new MeadAssistant.TOSNA();
			this.tabFortify = new System.Windows.Forms.TabPage();
			this.fortifier1 = new TOSNACalculator.Fortifier();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabFortify.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabFortify);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(6, 6);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(591, 443);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.tabPage1.Controls.Add(this.tosna1);
			this.tabPage1.Location = new System.Drawing.Point(4, 31);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(583, 408);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TOSNA Schedule";
			// 
			// tosna1
			// 
			this.tosna1.BackColor = System.Drawing.SystemColors.Control;
			this.tosna1.Location = new System.Drawing.Point(44, 34);
			this.tosna1.Name = "tosna1";
			this.tosna1.Size = new System.Drawing.Size(464, 311);
			this.tosna1.TabIndex = 0;
			// 
			// tabFortify
			// 
			this.tabFortify.BackColor = System.Drawing.SystemColors.ControlDark;
			this.tabFortify.Controls.Add(this.fortifier1);
			this.tabFortify.Location = new System.Drawing.Point(4, 31);
			this.tabFortify.Name = "tabFortify";
			this.tabFortify.Padding = new System.Windows.Forms.Padding(3);
			this.tabFortify.Size = new System.Drawing.Size(583, 340);
			this.tabFortify.TabIndex = 1;
			this.tabFortify.Text = "Batch Fortification";
			// 
			// fortifier1
			// 
			this.fortifier1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fortifier1.BackColor = System.Drawing.SystemColors.Control;
			this.fortifier1.Location = new System.Drawing.Point(69, 28);
			this.fortifier1.Name = "fortifier1";
			this.fortifier1.Size = new System.Drawing.Size(436, 246);
			this.fortifier1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 449);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
			this.Text = "Mead Assistant";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabFortify.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
