namespace SimpleCounter
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editPrefixsuffixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelCounter = new System.Windows.Forms.Label();
			this.labelPrefix = new System.Windows.Forms.Label();
			this.labelSuffix = new System.Windows.Forms.Label();
			this.editKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPrefixsuffixToolStripMenuItem,
            this.editKeysToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(162, 70);
			// 
			// editPrefixsuffixToolStripMenuItem
			// 
			this.editPrefixsuffixToolStripMenuItem.Name = "editPrefixsuffixToolStripMenuItem";
			this.editPrefixsuffixToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.editPrefixsuffixToolStripMenuItem.Text = "Edit prefix/suffix";
			this.editPrefixsuffixToolStripMenuItem.Click += new System.EventHandler(this.editPrefixsuffixToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// labelCounter
			// 
			this.labelCounter.AutoSize = true;
			this.labelCounter.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCounter.Location = new System.Drawing.Point(220, 0);
			this.labelCounter.Name = "labelCounter";
			this.labelCounter.Size = new System.Drawing.Size(68, 73);
			this.labelCounter.TabIndex = 2;
			this.labelCounter.Text = "0";
			this.labelCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.labelCounter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.labelCounter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			// 
			// labelPrefix
			// 
			this.labelPrefix.AutoSize = true;
			this.labelPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrefix.Location = new System.Drawing.Point(0, 0);
			this.labelPrefix.Name = "labelPrefix";
			this.labelPrefix.Size = new System.Drawing.Size(214, 73);
			this.labelPrefix.TabIndex = 4;
			this.labelPrefix.Text = "Prefix:";
			this.labelPrefix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.labelPrefix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.labelPrefix.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			// 
			// labelSuffix
			// 
			this.labelSuffix.AutoSize = true;
			this.labelSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSuffix.Location = new System.Drawing.Point(294, 0);
			this.labelSuffix.Name = "labelSuffix";
			this.labelSuffix.Size = new System.Drawing.Size(193, 73);
			this.labelSuffix.TabIndex = 5;
			this.labelSuffix.Text = "Suffix";
			this.labelSuffix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.labelSuffix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.labelSuffix.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			// 
			// editKeysToolStripMenuItem
			// 
			this.editKeysToolStripMenuItem.Name = "editKeysToolStripMenuItem";
			this.editKeysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editKeysToolStripMenuItem.Text = "Edit keys";
			this.editKeysToolStripMenuItem.Click += new System.EventHandler(this.editKeysToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 73);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.labelSuffix);
			this.Controls.Add(this.labelPrefix);
			this.Controls.Add(this.labelCounter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label labelCounter;
		private System.Windows.Forms.ToolStripMenuItem editPrefixsuffixToolStripMenuItem;
		private System.Windows.Forms.Label labelPrefix;
		private System.Windows.Forms.Label labelSuffix;
		private System.Windows.Forms.ToolStripMenuItem editKeysToolStripMenuItem;
	}
}

