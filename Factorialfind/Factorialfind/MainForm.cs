/*
 * Created by SharpDevelop.
 * User: Tech Tips
 * Date: 02/06/2021
 * Time: 10:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Factorialfind
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
		
		void Button1Click(object sender, EventArgs e)
		{
			int n, fact=1;
			n = Convert.ToInt32(textBox.Text);
			for( int i = 1; i<=n; i++)
				
			{
			fact= fact *i;
			}
			MessageBox.Show("Factorial of " +n+  "is =" + fact);
		}
	}
}
