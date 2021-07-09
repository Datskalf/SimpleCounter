namespace SimpleCounter
{
	partial class FormKeyBindings
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
			this.textBoxIncrement = new System.Windows.Forms.TextBox();
			this.textBoxDecrement = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSubmit = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxIncrement
			// 
			this.textBoxIncrement.Location = new System.Drawing.Point(72, 6);
			this.textBoxIncrement.MaxLength = 2;
			this.textBoxIncrement.Name = "textBoxIncrement";
			this.textBoxIncrement.Size = new System.Drawing.Size(94, 20);
			this.textBoxIncrement.TabIndex = 0;
			this.textBoxIncrement.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// textBoxDecrement
			// 
			this.textBoxDecrement.Location = new System.Drawing.Point(72, 33);
			this.textBoxDecrement.MaxLength = 2;
			this.textBoxDecrement.Name = "textBoxDecrement";
			this.textBoxDecrement.Size = new System.Drawing.Size(94, 20);
			this.textBoxDecrement.TabIndex = 1;
			this.textBoxDecrement.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Increment";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Decrement";
			// 
			// buttonSubmit
			// 
			this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSubmit.Location = new System.Drawing.Point(72, 59);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Size = new System.Drawing.Size(94, 23);
			this.buttonSubmit.TabIndex = 4;
			this.buttonSubmit.Text = "Submit";
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(12, 59);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(59, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormKeyBindings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(179, 91);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSubmit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDecrement);
			this.Controls.Add(this.textBoxIncrement);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormKeyBindings";
			this.Text = "FormKeyBindings";
			this.Load += new System.EventHandler(this.FormKeyBindings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxIncrement;
		private System.Windows.Forms.TextBox textBoxDecrement;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSubmit;
		private System.Windows.Forms.Button buttonCancel;
	}
}