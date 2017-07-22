/*
 * Created by SharpDevelop.
 * User: Will Kraft
 * Date: 7/22/2017
 * Time: 5:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MeadAssistant
{
	partial class TOSNA
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlYeastSliderOuter;
		private System.Windows.Forms.Panel pnlYeastSliderInner;
		private System.Windows.Forms.Label lblYeastReq;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radFermK;
		private System.Windows.Forms.RadioButton radFermO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip toolTip1;
		
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
			this.components = new System.ComponentModel.Container();
			this.pnlYeastSliderOuter = new System.Windows.Forms.Panel();
			this.pnlYeastSliderInner = new System.Windows.Forms.Panel();
			this.lblYeastReq = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.radFermO = new System.Windows.Forms.RadioButton();
			this.radFermK = new System.Windows.Forms.RadioButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlYeastSliderOuter.SuspendLayout();
			this.pnlYeastSliderInner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.pnlMain.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlYeastSliderOuter
			// 
			this.pnlYeastSliderOuter.Controls.Add(this.pnlYeastSliderInner);
			this.pnlYeastSliderOuter.Controls.Add(this.label1);
			this.pnlYeastSliderOuter.Location = new System.Drawing.Point(3, 41);
			this.pnlYeastSliderOuter.Name = "pnlYeastSliderOuter";
			this.pnlYeastSliderOuter.Size = new System.Drawing.Size(427, 53);
			this.pnlYeastSliderOuter.TabIndex = 0;
			// 
			// pnlYeastSliderInner
			// 
			this.pnlYeastSliderInner.Controls.Add(this.lblYeastReq);
			this.pnlYeastSliderInner.Controls.Add(this.trackBar1);
			this.pnlYeastSliderInner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlYeastSliderInner.Location = new System.Drawing.Point(0, 20);
			this.pnlYeastSliderInner.Name = "pnlYeastSliderInner";
			this.pnlYeastSliderInner.Size = new System.Drawing.Size(427, 33);
			this.pnlYeastSliderInner.TabIndex = 1;
			// 
			// lblYeastReq
			// 
			this.lblYeastReq.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblYeastReq.Location = new System.Drawing.Point(327, 0);
			this.lblYeastReq.Name = "lblYeastReq";
			this.lblYeastReq.Size = new System.Drawing.Size(100, 33);
			this.lblYeastReq.TabIndex = 1;
			this.lblYeastReq.Text = "Low";
			this.lblYeastReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblYeastReq.Click += new System.EventHandler(this.Label2Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(0, 0);
			this.trackBar1.Maximum = 2;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(333, 33);
			this.trackBar1.TabIndex = 0;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar1.Value = 1;
			this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1ValueChanged);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(427, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Yeast Strain Nitrogen Requirements";
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.flowLayoutPanel1);
			this.pnlMain.Location = new System.Drawing.Point(3, 3);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(449, 146);
			this.pnlMain.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.pnlYeastSliderOuter);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(449, 146);
			this.flowLayoutPanel1.TabIndex = 0;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radFermK);
			this.panel1.Controls.Add(this.radFermO);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(427, 27);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(1, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Batch Nutrient Protocol:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// radFermO
			// 
			this.radFermO.Checked = true;
			this.radFermO.Location = new System.Drawing.Point(139, 3);
			this.radFermO.Name = "radFermO";
			this.radFermO.Size = new System.Drawing.Size(125, 24);
			this.radFermO.TabIndex = 1;
			this.radFermO.TabStop = true;
			this.radFermO.Text = "Organic (TOSNA)";
			this.toolTip1.SetToolTip(this.radFermO, "Uses settings for Fermaid O nutrient. Organic nitrogen only!");
			this.radFermO.UseVisualStyleBackColor = true;
			// 
			// radFermK
			// 
			this.radFermK.Location = new System.Drawing.Point(255, 2);
			this.radFermK.Name = "radFermK";
			this.radFermK.Size = new System.Drawing.Size(126, 24);
			this.radFermK.TabIndex = 2;
			this.radFermK.Text = "Inorganic (TiOSNA)";
			this.toolTip1.SetToolTip(this.radFermK, "Uses settings for nutrient addition with Fermaid K (or similar products \r\nwith in" +
		"organic nitrogen sources like DAP)");
			this.radFermK.UseVisualStyleBackColor = true;
			// 
			// TOSNA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlMain);
			this.Name = "TOSNA";
			this.Size = new System.Drawing.Size(471, 392);
			this.pnlYeastSliderOuter.ResumeLayout(false);
			this.pnlYeastSliderInner.ResumeLayout(false);
			this.pnlYeastSliderInner.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.pnlMain.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
