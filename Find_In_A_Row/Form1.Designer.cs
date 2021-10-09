
namespace Find_In_A_Row
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GetDir = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.RadioButtonGroupBox = new System.Windows.Forms.GroupBox();
			this.LookOne = new System.Windows.Forms.RadioButton();
			this.LookInARow = new System.Windows.Forms.RadioButton();
			this.Text_Result = new System.Windows.Forms.TextBox();
			this.DirName = new System.Windows.Forms.Label();
			this.MadeBy = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.RadioButtonGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// GetDir
			// 
			this.GetDir.Location = new System.Drawing.Point(10, 11);
			this.GetDir.Name = "GetDir";
			this.GetDir.Size = new System.Drawing.Size(165, 34);
			this.GetDir.TabIndex = 0;
			this.GetDir.Text = "폴더 불러오기";
			this.GetDir.UseVisualStyleBackColor = true;
			this.GetDir.Click += new System.EventHandler(this.GetDir_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.RadioButtonGroupBox);
			this.panel1.Controls.Add(this.Text_Result);
			this.panel1.Controls.Add(this.DirName);
			this.panel1.Controls.Add(this.GetDir);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(539, 426);
			this.panel1.TabIndex = 1;
			// 
			// RadioButtonGroupBox
			// 
			this.RadioButtonGroupBox.Controls.Add(this.LookOne);
			this.RadioButtonGroupBox.Controls.Add(this.LookInARow);
			this.RadioButtonGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.RadioButtonGroupBox.Location = new System.Drawing.Point(210, 11);
			this.RadioButtonGroupBox.Name = "RadioButtonGroupBox";
			this.RadioButtonGroupBox.Size = new System.Drawing.Size(300, 54);
			this.RadioButtonGroupBox.TabIndex = 5;
			this.RadioButtonGroupBox.TabStop = false;
			// 
			// LookOne
			// 
			this.LookOne.AutoSize = true;
			this.LookOne.Checked = true;
			this.LookOne.Cursor = System.Windows.Forms.Cursors.Default;
			this.LookOne.Location = new System.Drawing.Point(6, 19);
			this.LookOne.Name = "LookOne";
			this.LookOne.Size = new System.Drawing.Size(133, 29);
			this.LookOne.TabIndex = 1;
			this.LookOne.TabStop = true;
			this.LookOne.Text = "하나씩 보기";
			this.LookOne.UseVisualStyleBackColor = true;
			this.LookOne.CheckedChanged += new System.EventHandler(this.LookOne_CheckedChanged);
			// 
			// LookInARow
			// 
			this.LookInARow.AutoSize = true;
			this.LookInARow.Location = new System.Drawing.Point(161, 19);
			this.LookInARow.Name = "LookInARow";
			this.LookInARow.Size = new System.Drawing.Size(133, 29);
			this.LookInARow.TabIndex = 2;
			this.LookInARow.Text = "이어서 보기";
			this.LookInARow.UseVisualStyleBackColor = true;
			this.LookInARow.CheckedChanged += new System.EventHandler(this.LookInARow_CheckedChanged);
			// 
			// Text_Result
			// 
			this.Text_Result.Location = new System.Drawing.Point(10, 86);
			this.Text_Result.Multiline = true;
			this.Text_Result.Name = "Text_Result";
			this.Text_Result.ReadOnly = true;
			this.Text_Result.Size = new System.Drawing.Size(515, 337);
			this.Text_Result.TabIndex = 4;
			// 
			// DirName
			// 
			this.DirName.AutoSize = true;
			this.DirName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DirName.Location = new System.Drawing.Point(10, 58);
			this.DirName.Name = "DirName";
			this.DirName.Size = new System.Drawing.Size(90, 25);
			this.DirName.TabIndex = 3;
			this.DirName.Text = "폴더 이름";
			// 
			// MadeBy
			// 
			this.MadeBy.AutoSize = true;
			this.MadeBy.Location = new System.Drawing.Point(401, 435);
			this.MadeBy.Name = "MadeBy";
			this.MadeBy.Size = new System.Drawing.Size(150, 25);
			this.MadeBy.TabIndex = 2;
			this.MadeBy.Text = "Made by E00108";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 469);
			this.Controls.Add(this.MadeBy);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "누락 확인";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.RadioButtonGroupBox.ResumeLayout(false);
			this.RadioButtonGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GetDir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton LookInARow;
		private System.Windows.Forms.Label DirName;
		private System.Windows.Forms.TextBox Text_Result;
		private System.Windows.Forms.Label MadeBy;
		private System.Windows.Forms.GroupBox RadioButtonGroupBox;
		public System.Windows.Forms.RadioButton LookOne;
	}
}

