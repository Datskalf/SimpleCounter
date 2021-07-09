namespace SimpleCounter
{
	partial class PrefixSuffix
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPrefix = new System.Windows.Forms.TextBox();
			this.textBoxSuffix = new System.Windows.Forms.TextBox();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prefix:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Suffix:";
			// 
			// textBoxPrefix
			// 
			this.textBoxPrefix.Location = new System.Drawing.Point(53, 6);
			this.textBoxPrefix.Name = "textBoxPrefix";
			this.textBoxPrefix.Size = new System.Drawing.Size(325, 20);
			this.textBoxPrefix.TabIndex = 2;
			this.textBoxPrefix.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// textBoxSuffix
			// 
			this.textBoxSuffix.Location = new System.Drawing.Point(53, 32);
			this.textBoxSuffix.Name = "textBoxSuffix";
			this.textBoxSuffix.Size = new System.Drawing.Size(325, 20);
			this.textBoxSuffix.TabIndex = 3;
			this.textBoxSuffix.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSubmit.Location = new System.Drawing.Point(190, 58);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(188, 23);
			this.buttonSubmit.TabIndex = 4;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(12, 58);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(172, 23);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// PrefixSuffix
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 93);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.textBoxSuffix);
			this.Controls.Add(this.textBoxPrefix);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PrefixSuffix";
			this.Text = "PrefixSuffix";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPrefix;
		private System.Windows.Forms.TextBox textBoxSuffix;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.Button buttonExit;
	}
}