using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCounter
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent();
		}


		#region Global variables

		public string prefix = "";
		public string suffix = "";
		public int margin = 1;
		public int currentNumber = 0;
		public Keys incrementKey = Keys.I;
		public Keys decrementKey = Keys.K;

		#endregion


		private void Form1_Load (object sender, EventArgs e)
		{
			updateGUI();
		}


		#region Draggable window

		private bool mouseDown;
		private Point lastLocation;

		private void Form1_MouseDown (object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void Form1_MouseMove (object sender, MouseEventArgs e)
		{
			if(mouseDown && e.Button == MouseButtons.Left)
			{
				this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
				this.Update();
			}
		}

		private void Form1_MouseUp (object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		#endregion

		private void exitToolStripMenuItem_Click (object sender, EventArgs e)
		{
			Application.Exit();
		}


		#region Prefix/Suffix

		private void editPrefixsuffixToolStripMenuItem_Click (object sender, EventArgs e)
		{
			PrefixSuffix formGetPrefix = new PrefixSuffix();

			if (formGetPrefix.ShowDialog(this) == DialogResult.OK)
			{
				prefix = formGetPrefix.prefix;
				suffix = formGetPrefix.suffix;
			}

			formGetPrefix.Dispose();

			labelPrefix.Text = prefix;
			labelSuffix.Text = suffix;

			updateGUI();
		}

		private void updateGUI ()
		{
			labelPrefix.Width = TextRenderer.MeasureText(labelPrefix.Text, labelPrefix.Font).Width;
			labelPrefix.Location = new Point(0, 0);

			labelCounter.Text = currentNumber.ToString();
			labelCounter.Width = TextRenderer.MeasureText(labelCounter.Text, labelCounter.Font).Width;
			labelCounter.Location = new Point(labelPrefix.Location.X + labelPrefix.Width + margin, 0);

			labelSuffix.Width = TextRenderer.MeasureText(labelSuffix.Text, labelSuffix.Font).Width;
			labelSuffix.Location = new Point(labelCounter.Location.X + labelCounter.Width + margin, 0);

			this.Width = labelSuffix.Location.X + labelSuffix.Width;
		}


		#endregion

		private void Form1_KeyDown (object sender, KeyEventArgs e)
		{
			Console.WriteLine("Key pressed: " + e.KeyCode.ToString());

			if (e.KeyCode == incrementKey)
				currentNumber++;
			else if (e.KeyCode == decrementKey)
				currentNumber--;

			updateGUI();
		}

		private void editKeysToolStripMenuItem_Click (object sender, EventArgs e)
		{
			FormKeyBindings newKeys = new FormKeyBindings(this);

			if (newKeys.ShowDialog(this) == DialogResult.OK)
			{
				incrementKey = newKeys.IncrementKey;
				decrementKey = newKeys.DecrementKey;
			}

			newKeys.Dispose();
		}
	}
}
