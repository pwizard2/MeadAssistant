/*
MeadAssistant
Copyright (C) 2017, Will Kraft.

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <http://www.gnu.org/licenses/>.
 * 
 * Created by SharpDevelop.
 * User: Will Kraft
 * Date: 5/13/2017
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TOSNACalculator
{
	/// <summary>
	/// Description of Fortifier.
	/// </summary>
	public partial class Fortifier : UserControl
	{
		internal const int GallonSize = 128;
		// number of fluid 0z in a complete gallon.
			
		/// <summary>
		/// Gets or sets current batch size, in gallons. 
		/// </summary>
		internal Decimal BatchSize{ get { return batchSzGal.Value; } set { batchSzGal.Value = value; } }
		
		/// <summary>
		/// Gets or sets the current batch size in fluid ounces.
		/// </summary>
		internal Decimal BatchFluidOz{ get { return BatchSize * GallonSize; } }
		
		/// <summary>
		/// Gets or sets the current batch's current alcohol content in fl-oz.
		/// </summary>
		internal Decimal BatchAlcoholFluidOz { 
			get { 
				return (NaturalABV * BatchFluidOz) / 100;
			}
		}
	
		/// <summary>
		/// Gets the measurement factor in fluid oz for a teaspoon. 
		/// </summary>
		private Decimal ExtraTspFluidOz {
			get {				
				return ((Decimal)0.1666666666667 * udExtraTsp.Value) * (BoozeProof / 2);
			}
		}
		
		/// <summary>
		/// Gets the measurement factor in fluid oz for a tablespoon. 
		/// </summary>
		private Decimal ExtraTbspFluidOz {
			get {				
				return ((Decimal)0.5 * udExtraTbsp.Value) * (BoozeProof / 2);
			}
		}
		
				
		/// <summary>
		/// Gets or sets the current batch's OriginalGravity.
		/// </summary>
		internal Decimal OG{ get { return udbatchOG.Value; } set { udbatchOG.Value = value; } }
		
		/// <summary>
		/// Gets or sets the current batch's final/current gravity.
		/// </summary>
		internal Decimal FG{ get { return udbatchFG.Value; } set { udbatchFG.Value = value; } }
		
		/// <summary>
		/// Gets the calculated ABV for this batch.
		/// </summary>
		internal Decimal NaturalABV {
			get {
				return Math.Round((OG - FG) * (Decimal)131.25, 8);
			}
		}
		
		/// <summary>
		/// Gets or sets the current proof of the booze to be added.
		/// </summary>
		internal Decimal BoozeProof{ get { return udBoozeProof.Value / 100; } set { udBoozeProof.Value = value; } }
		
		/// <summary>
		/// Gets or sets the amount of alcohol Fluid OZ in the booze addition. Includes Extra values for adjustment.
		/// </summary>
		internal Decimal BoozeAlcoholFluidOz { 
			get {
				return ((BoozeCups * 8) * (BoozeProof / 2)) + ExtraTbspFluidOz + ExtraTspFluidOz;
			}
		}
		
		/// <summary>
		/// Gets or sets the number of cups of booze to be added.
		/// </summary>
		internal Decimal BoozeCups{ get { return udBoozeCups.Value; } set { udBoozeCups.Value = value; } }
		
		
		internal Decimal NewABV{ get; set; }
		
		internal Decimal AddedPercentage { 
			get { 
				if ((NewABV - NaturalABV) < 0)
					return 0;
				
				return Math.Round(NewABV - NaturalABV, 4); 
			} 
		}
		
		public Fortifier()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Calculate();
		}
		void UdBoozeProofValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}
		void UdBoozeCupsValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}
		void UdbatchFGValueChanged(object sender, EventArgs e)
		{
			Calculate();
			udbatchOG.Minimum=((NumericUpDown)sender).Value;
		}
		void UdbatchOGValueChanged(object sender, EventArgs e)
		{
			Calculate();
			udbatchFG.Maximum=((NumericUpDown)sender).Value;
			
		}
		void BatchSzGalValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}
		
		private void Calculate()
		{

			txtCurrentABV.Text = Math.Round(NaturalABV,2).ToString() + "%";
			
			NewABV = ((BoozeAlcoholFluidOz + BatchAlcoholFluidOz) / (BatchFluidOz + (BoozeCups * 8))) * 100;
			
			txtNewABV.Text = Math.Round(NewABV, 2).ToString() + "% ABV";
			txtAdded.Text = AddedPercentage.ToString() + "%";
			
		
			
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		
		void UdTspValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}
		
		void RadioButton1Click(object sender, EventArgs e)
		{
			Calculate();
		}
		
		void RadTspClick(object sender, EventArgs e)
		{
			Calculate();
		}
		void UdExtraTspValueChanged(object sender, EventArgs e)
		{
			Calculate();	
		}
		void UdExtraTbspValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}
	}
}
