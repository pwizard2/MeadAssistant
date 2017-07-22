/*
 * Created by SharpDevelop.
 * User: Will Kraft
 * Date: 5/13/2017
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TOSNACalculator
{
	partial class Fortifier
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown batchSzGal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown udbatchFG;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown udbatchOG;
		private System.Windows.Forms.TextBox txtCurrentABV;
		private System.Windows.Forms.TextBox txtNewABV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown udBoozeCups;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown udBoozeProof;
		private System.Windows.Forms.TextBox txtAdded;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.NumericUpDown udExtraTbsp;
		private System.Windows.Forms.NumericUpDown udExtraTsp;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Panel panel1;
		
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.udExtraTbsp = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.udExtraTsp = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.txtAdded = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNewABV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.udBoozeCups = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.udBoozeProof = new System.Windows.Forms.NumericUpDown();
			this.txtCurrentABV = new System.Windows.Forms.TextBox();
			this.udbatchFG = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.udbatchOG = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.batchSzGal = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udExtraTbsp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udExtraTsp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udBoozeCups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udBoozeProof)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udbatchFG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udbatchOG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batchSzGal)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flowLayoutPanel1);
			this.groupBox2.Location = new System.Drawing.Point(16, 113);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(199, 45);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Extra Booze (Fine Adjustment)";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.udExtraTbsp);
			this.flowLayoutPanel1.Controls.Add(this.label9);
			this.flowLayoutPanel1.Controls.Add(this.udExtraTsp);
			this.flowLayoutPanel1.Controls.Add(this.label10);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 26);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// udExtraTbsp
			// 
			this.udExtraTbsp.Location = new System.Drawing.Point(3, 3);
			this.udExtraTbsp.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.udExtraTbsp.Name = "udExtraTbsp";
			this.udExtraTbsp.Size = new System.Drawing.Size(45, 20);
			this.udExtraTbsp.TabIndex = 0;
			this.udExtraTbsp.ValueChanged += new System.EventHandler(this.UdExtraTbspValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(51, 6);
			this.label9.Margin = new System.Windows.Forms.Padding(3, 6, 10, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Tbsp.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// udExtraTsp
			// 
			this.udExtraTsp.DecimalPlaces = 2;
			this.udExtraTsp.Increment = new decimal(new int[] {
			25,
			0,
			0,
			131072});
			this.udExtraTsp.Location = new System.Drawing.Point(98, 3);
			this.udExtraTsp.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.udExtraTsp.Name = "udExtraTsp";
			this.udExtraTsp.Size = new System.Drawing.Size(45, 20);
			this.udExtraTsp.TabIndex = 2;
			this.udExtraTsp.ValueChanged += new System.EventHandler(this.UdExtraTspValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(146, 6);
			this.label10.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(28, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Tsp.";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAdded
			// 
			this.txtAdded.BackColor = System.Drawing.SystemColors.Window;
			this.txtAdded.Location = new System.Drawing.Point(335, 3);
			this.txtAdded.Name = "txtAdded";
			this.txtAdded.ReadOnly = true;
			this.txtAdded.Size = new System.Drawing.Size(59, 20);
			this.txtAdded.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(253, 6);
			this.label8.Margin = new System.Windows.Forms.Padding(14, 6, 3, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Artificial Boost:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNewABV
			// 
			this.txtNewABV.BackColor = System.Drawing.SystemColors.Window;
			this.txtNewABV.Location = new System.Drawing.Point(150, 3);
			this.txtNewABV.Name = "txtNewABV";
			this.txtNewABV.ReadOnly = true;
			this.txtNewABV.Size = new System.Drawing.Size(86, 20);
			this.txtNewABV.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 6);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "New ABV After Fortification: ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// udBoozeCups
			// 
			this.udBoozeCups.DecimalPlaces = 2;
			this.udBoozeCups.Increment = new decimal(new int[] {
			25,
			0,
			0,
			131072});
			this.udBoozeCups.Location = new System.Drawing.Point(333, 76);
			this.udBoozeCups.Name = "udBoozeCups";
			this.udBoozeCups.Size = new System.Drawing.Size(59, 20);
			this.udBoozeCups.TabIndex = 12;
			this.udBoozeCups.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.udBoozeCups.ValueChanged += new System.EventHandler(this.UdBoozeCupsValueChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(229, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Cups Of Booze:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(263, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Booze Proof:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// udBoozeProof
			// 
			this.udBoozeProof.DecimalPlaces = 1;
			this.udBoozeProof.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.udBoozeProof.Location = new System.Drawing.Point(333, 46);
			this.udBoozeProof.Maximum = new decimal(new int[] {
			190,
			0,
			0,
			0});
			this.udBoozeProof.Minimum = new decimal(new int[] {
			20,
			0,
			0,
			0});
			this.udBoozeProof.Name = "udBoozeProof";
			this.udBoozeProof.Size = new System.Drawing.Size(59, 20);
			this.udBoozeProof.TabIndex = 9;
			this.udBoozeProof.Value = new decimal(new int[] {
			190,
			0,
			0,
			0});
			this.udBoozeProof.ValueChanged += new System.EventHandler(this.UdBoozeProofValueChanged);
			// 
			// txtCurrentABV
			// 
			this.txtCurrentABV.Location = new System.Drawing.Point(335, 17);
			this.txtCurrentABV.Name = "txtCurrentABV";
			this.txtCurrentABV.ReadOnly = true;
			this.txtCurrentABV.Size = new System.Drawing.Size(56, 20);
			this.txtCurrentABV.TabIndex = 8;
			// 
			// udbatchFG
			// 
			this.udbatchFG.DecimalPlaces = 3;
			this.udbatchFG.Increment = new decimal(new int[] {
			5,
			0,
			0,
			196608});
			this.udbatchFG.Location = new System.Drawing.Point(142, 74);
			this.udbatchFG.Minimum = new decimal(new int[] {
			900,
			0,
			0,
			196608});
			this.udbatchFG.Name = "udbatchFG";
			this.udbatchFG.Size = new System.Drawing.Size(59, 20);
			this.udbatchFG.TabIndex = 7;
			this.udbatchFG.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.udbatchFG.ValueChanged += new System.EventHandler(this.UdbatchFGValueChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(72, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Batch FG:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(72, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Batch OG:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// udbatchOG
			// 
			this.udbatchOG.DecimalPlaces = 3;
			this.udbatchOG.Increment = new decimal(new int[] {
			10,
			0,
			0,
			196608});
			this.udbatchOG.Location = new System.Drawing.Point(142, 44);
			this.udbatchOG.Minimum = new decimal(new int[] {
			5,
			0,
			0,
			65536});
			this.udbatchOG.Name = "udbatchOG";
			this.udbatchOG.Size = new System.Drawing.Size(59, 20);
			this.udbatchOG.TabIndex = 4;
			this.udbatchOG.Value = new decimal(new int[] {
			112,
			0,
			0,
			131072});
			this.udbatchOG.ValueChanged += new System.EventHandler(this.UdbatchOGValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(207, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Natural ABV:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Batch size (US Gallons):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// batchSzGal
			// 
			this.batchSzGal.DecimalPlaces = 2;
			this.batchSzGal.Increment = new decimal(new int[] {
			10,
			0,
			0,
			131072});
			this.batchSzGal.Location = new System.Drawing.Point(142, 16);
			this.batchSzGal.Minimum = new decimal(new int[] {
			5,
			0,
			0,
			65536});
			this.batchSzGal.Name = "batchSzGal";
			this.batchSzGal.Size = new System.Drawing.Size(59, 20);
			this.batchSzGal.TabIndex = 0;
			this.batchSzGal.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.batchSzGal.ValueChanged += new System.EventHandler(this.BatchSzGalValueChanged);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label7);
			this.flowLayoutPanel2.Controls.Add(this.txtNewABV);
			this.flowLayoutPanel2.Controls.Add(this.label8);
			this.flowLayoutPanel2.Controls.Add(this.txtAdded);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 200);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(418, 29);
			this.flowLayoutPanel2.TabIndex = 20;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.flowLayoutPanel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.batchSzGal);
			this.panel1.Controls.Add(this.udBoozeCups);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.udbatchOG);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.udBoozeProof);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtCurrentABV);
			this.panel1.Controls.Add(this.udbatchFG);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 229);
			this.panel1.TabIndex = 1;
			// 
			// Fortifier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.panel1);
			this.Name = "Fortifier";
			this.Size = new System.Drawing.Size(418, 229);
			this.groupBox2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udExtraTbsp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udExtraTsp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udBoozeCups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udBoozeProof)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udbatchFG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udbatchOG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.batchSzGal)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
