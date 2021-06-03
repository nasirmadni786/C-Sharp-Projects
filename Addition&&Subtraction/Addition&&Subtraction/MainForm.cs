/*
 * Created by SharpDevelop.
 * User: Tech Tips
 * Date: 03/06/2021
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Addition__Subtraction
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnResultClick(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtNum1.Text);
			double num2 = double.Parse(txtNum2.Text);
			
			double result = 0;
			
			if(radAddition.Checked == true)
			{
			result = num1 + num2;
			}
			
			else if (radSubtraction.Checked == true)
			{
			result = num1 - num2;
			}
			txtResult.Text = result.ToString();
			
			
		}
	}
}
