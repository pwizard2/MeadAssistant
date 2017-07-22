/*
 * Created by SharpDevelop.
 * User: Will Kraft
 * Date: 5/13/2017
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TOSNACalculator
{
	partial class BatchPlanner
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlBatchSettings;
		private System.Windows.Forms.GroupBox grpYeast;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTOSNAFactor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtLag;
		private System.Windows.Forms.TextBox txtN2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbYeastStrain;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtABV;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBrix;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAtten;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFG;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOG;
		private System.Windows.Forms.TextBox txtYield;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.Windows.Forms.Label label2;
			this.pnlBatchSettings = new System.Windows.Forms.Panel();
			this.grpYeast = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTOSNAFactor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtLag = new System.Windows.Forms.TextBox();
			this.txtN2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbYeastStrain = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtABV = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBrix = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAtten = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFG = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOG = new System.Windows.Forms.TextBox();
			this.txtYield = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			this.pnlBatchSettings.SuspendLayout();
			this.grpYeast.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBatchSettings
			// 
			this.pnlBatchSettings.Controls.Add(this.grpYeast);
			this.pnlBatchSettings.Controls.Add(this.groupBox1);
			this.pnlBatchSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBatchSettings.Location = new System.Drawing.Point(0, 0);
			this.pnlBatchSettings.Name = "pnlBatchSettings";
			this.pnlBatchSettings.Padding = new System.Windows.Forms.Padding(6);
			this.pnlBatchSettings.Size = new System.Drawing.Size(613, 241);
			this.pnlBatchSettings.TabIndex = 2;
			// 
			// grpYeast
			// 
			this.grpYeast.Controls.Add(this.panel3);
			this.grpYeast.Controls.Add(this.label5);
			this.grpYeast.Controls.Add(this.cmbYeastStrain);
			this.grpYeast.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpYeast.Location = new System.Drawing.Point(6, 119);
			this.grpYeast.Name = "grpYeast";
			this.grpYeast.Size = new System.Drawing.Size(601, 116);
			this.grpYeast.TabIndex = 1;
			this.grpYeast.TabStop = false;
			this.grpYeast.Text = "Yeast";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.txtTOSNAFactor);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.txtLag);
			this.panel3.Controls.Add(this.txtN2);
			this.panel3.Location = new System.Drawing.Point(275, 14);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(194, 96);
			this.panel3.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(2, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Nitrogen Req:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTOSNAFactor
			// 
			this.txtTOSNAFactor.Location = new System.Drawing.Point(108, 68);
			this.txtTOSNAFactor.Name = "txtTOSNAFactor";
			this.txtTOSNAFactor.ReadOnly = true;
			this.txtTOSNAFactor.Size = new System.Drawing.Size(74, 20);
			this.txtTOSNAFactor.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(60, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Lag:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(15, 67);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 16);
			this.label9.TabIndex = 14;
			this.label9.Text = "TOSNA Factor:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLag
			// 
			this.txtLag.Location = new System.Drawing.Point(108, 9);
			this.txtLag.Name = "txtLag";
			this.txtLag.ReadOnly = true;
			this.txtLag.Size = new System.Drawing.Size(74, 20);
			this.txtLag.TabIndex = 11;
			// 
			// txtN2
			// 
			this.txtN2.Location = new System.Drawing.Point(108, 36);
			this.txtN2.Name = "txtN2";
			this.txtN2.ReadOnly = true;
			this.txtN2.Size = new System.Drawing.Size(74, 20);
			this.txtN2.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Strain:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbYeastStrain
			// 
			this.cmbYeastStrain.BackColor = System.Drawing.SystemColors.Window;
			this.cmbYeastStrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbYeastStrain.FormattingEnabled = true;
			this.cmbYeastStrain.Items.AddRange(new object[] {
			"Lalvin D47",
			"Lalvin D21",
			"Lalvin K1V-1116",
			"Lalvin EC-1118",
			"Red Star Cotes Des Blanc",
			"Red Star Montrachet",
			"Wyeast 1138"});
			this.cmbYeastStrain.Location = new System.Drawing.Point(53, 17);
			this.cmbYeastStrain.Name = "cmbYeastStrain";
			this.cmbYeastStrain.Size = new System.Drawing.Size(188, 21);
			this.cmbYeastStrain.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtABV);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtBrix);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtAtten);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtFG);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtOG);
			this.groupBox1.Controls.Add(label2);
			this.groupBox1.Controls.Add(this.txtYield);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(601, 113);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Batch Settings";
			// 
			// txtABV
			// 
			this.txtABV.Location = new System.Drawing.Point(127, 83);
			this.txtABV.Name = "txtABV";
			this.txtABV.ReadOnly = true;
			this.txtABV.Size = new System.Drawing.Size(48, 20);
			this.txtABV.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(22, 83);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 19);
			this.label10.TabIndex = 10;
			this.label10.Text = "Final ABV:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBrix
			// 
			this.txtBrix.Location = new System.Drawing.Point(127, 53);
			this.txtBrix.Name = "txtBrix";
			this.txtBrix.ReadOnly = true;
			this.txtBrix.Size = new System.Drawing.Size(48, 20);
			this.txtBrix.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(23, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Sugar (Brix):";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAtten
			// 
			this.txtAtten.Location = new System.Drawing.Point(383, 84);
			this.txtAtten.Name = "txtAtten";
			this.txtAtten.ReadOnly = true;
			this.txtAtten.Size = new System.Drawing.Size(48, 20);
			this.txtAtten.TabIndex = 7;
			this.txtAtten.Text = "100%";
			// 
			// label4
			// 
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label4.Location = new System.Drawing.Point(277, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Target Attenuation:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFG
			// 
			this.txtFG.Location = new System.Drawing.Point(383, 57);
			this.txtFG.Name = "txtFG";
			this.txtFG.Size = new System.Drawing.Size(48, 20);
			this.txtFG.TabIndex = 5;
			this.txtFG.Text = "1.000";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(277, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Target Gravity (FG):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtOG
			// 
			this.txtOG.Location = new System.Drawing.Point(383, 27);
			this.txtOG.Name = "txtOG";
			this.txtOG.Size = new System.Drawing.Size(48, 20);
			this.txtOG.TabIndex = 3;
			this.txtOG.Text = "1.100";
			// 
			// label2
			// 
			label2.Location = new System.Drawing.Point(264, 27);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(113, 17);
			label2.TabIndex = 2;
			label2.Text = "Original Gravity (OG):";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtYield
			// 
			this.txtYield.Location = new System.Drawing.Point(127, 24);
			this.txtYield.Name = "txtYield";
			this.txtYield.Size = new System.Drawing.Size(35, 20);
			this.txtYield.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Batch Yield (Gallons):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BatchPlanner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlBatchSettings);
			this.Name = "BatchPlanner";
			this.Size = new System.Drawing.Size(613, 248);
			this.pnlBatchSettings.ResumeLayout(false);
			this.grpYeast.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
