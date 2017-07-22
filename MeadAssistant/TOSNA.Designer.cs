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
			this.pnlYeastSliderOuter = new System.Windows.Forms.Panel();
			this.pnlYeastSliderInner = new System.Windows.Forms.Panel();
			this.lblYeastReq = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlYeastSliderOuter.SuspendLayout();
			this.pnlYeastSliderInner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlYeastSliderOuter
			// 
			this.pnlYeastSliderOuter.Controls.Add(this.pnlYeastSliderInner);
			this.pnlYeastSliderOuter.Controls.Add(this.label1);
			this.pnlYeastSliderOuter.Location = new System.Drawing.Point(19, 180);
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
			// TOSNA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlYeastSliderOuter);
			this.Name = "TOSNA";
			this.Size = new System.Drawing.Size(471, 321);
			this.pnlYeastSliderOuter.ResumeLayout(false);
			this.pnlYeastSliderInner.ResumeLayout(false);
			this.pnlYeastSliderInner.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
