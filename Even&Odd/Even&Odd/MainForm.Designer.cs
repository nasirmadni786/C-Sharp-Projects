﻿/*
 * Created by SharpDevelop.
 * User: Tech Tips
 * Date: 02/06/2021
 * Time: 11:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Even_Odd
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Number";
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(107, 38);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(191, 20);
			this.textBox.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 28);
			this.button1.TabIndex = 2;
			this.button1.Text = "Find Even&Odd";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Even&Odd";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label label1;
	}
}
