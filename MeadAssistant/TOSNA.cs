/*MeadAssistant
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
 * Date: 7/22/2017
 * Time: 5:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace MeadAssistant
{
	/// <summary>
	/// TOSNA 2.0 Calculator, based on the formulas from www.meadmaderight.com.
	/// </summary>
	public partial class TOSNA : UserControl
	{
		/// <summary>
		/// Gets or sets the amount of nitrogen this batch requires. --Will Kraft (7/22/17).
		/// </summary>
		internal NitrogenDemands NReq{ get; set; }
		
		/// <summary>
		/// Gets the TOSNA 2.0 nitrogen factor. --Will Kraft (7/22/17).
		/// </summary>
		internal double NitrogenFactor {
			
			get {
				switch (NReq) {
					default: // Low 
						return 0.75;
					
					case NitrogenDemands.Medium:
						return 0.9;						
				
					case NitrogenDemands.High:
						return 1.25;
				}
			}
		}
		
		//###########################################################################
		public TOSNA()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			trackBar1.Value = 0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//###########################################################################
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		
		//###########################################################################
		void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			var _idx = ((TrackBar)sender).Value;
			NReq = (NitrogenDemands)_idx;
			lblYeastReq.Text = NReq.ToString();
			
		}
	}
}
