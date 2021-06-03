/*
 * Created by SharpDevelop.
 * User: Tech Tips
 * Date: 03/06/2021
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Addition__Subtraction
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.radAddition = new System.Windows.Forms.RadioButton();
			this.radSubtraction = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btnResult = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// radAddition
			// 
			this.radAddition.Location = new System.Drawing.Point(113, 256);
			this.radAddition.Name = "radAddition";
			this.radAddition.Size = new System.Drawing.Size(104, 24);
			this.radAddition.TabIndex = 0;
			this.radAddition.TabStop = true;
			this.radAddition.Text = "Addition";
			this.radAddition.UseVisualStyleBackColor = true;
			// 
			// radSubtraction
			// 
			this.radSubtraction.Location = new System.Drawing.Point(453, 256);
			this.radSubtraction.Name = "radSubtraction";
			this.radSubtraction.Size = new System.Drawing.Size(104, 24);
			this.radSubtraction.TabIndex = 1;
			this.radSubtraction.TabStop = true;
			this.radSubtraction.Text = "Subtarction";
			this.radSubtraction.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(72, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter First Number";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Enter Second Number";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(73, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 35);
			this.label3.TabIndex = 4;
			this.label3.Text = "Result";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(310, 31);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(249, 20);
			this.txtNum1.TabIndex = 5;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(310, 88);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(247, 20);
			this.txtNum2.TabIndex = 6;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(312, 158);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(247, 20);
			this.txtResult.TabIndex = 7;
			// 
			// btnResult
			// 
			this.btnResult.Location = new System.Drawing.Point(228, 308);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(156, 55);
			this.btnResult.TabIndex = 8;
			this.btnResult.Text = "Calculate";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.BtnResultClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(673, 397);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radSubtraction);
			this.Controls.Add(this.radAddition);
			this.Name = "MainForm";
			this.Text = "Addition&&Subtraction";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radSubtraction;
		private System.Windows.Forms.RadioButton radAddition;
	}
}
