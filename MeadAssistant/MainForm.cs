/* MeadAssistant
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
 * 
 * Created by SharpDevelop.
 * User: Will Kraft
 * Date: 10/22/2016
 * Time: 10:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TOSNACalculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			fortifier1.OG=1.140M;
			fortifier1.FG=1.030M;
			fortifier1.BoozeCups=0.5M;
			fortifier1.BatchSize=0.9M;
			
			tabControl1.SelectedIndex=1;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
