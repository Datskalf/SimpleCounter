using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleCounter
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent();
		}


		#region Current settings

		public string prefix = "";
		public string suffix = "";
		public int margin = 1;
		public int currentNumber = 0;
		public Keys incrementKey = Keys.I;
		public Keys decrementKey = Keys.K;

		public Color bgColor = Color.White;

		private string currentCounterFile;
		private string currentLayoutFile;

		#endregion


		private void Form1_Load (object sender, EventArgs e)
		{
			updateGUI();
		}

		private void updateGUI ()
		{
			labelPrefix.Text = prefix;
			labelPrefix.Width = TextRenderer.MeasureText(labelPrefix.Text, labelPrefix.Font).Width;
			labelPrefix.Location = new Point(0, 0);

			tbCount.Text = currentNumber.ToString();
			tbCount.Width = TextRenderer.MeasureText(tbCount.Text, tbCount.Font).Width;
			tbCount.Location = new Point(labelPrefix.Location.X + labelPrefix.Width + margin, 0);

			labelSuffix.Text = suffix;
			labelSuffix.Width = TextRenderer.MeasureText(labelSuffix.Text, labelSuffix.Font).Width;
			labelSuffix.Location = new Point(tbCount.Location.X + tbCount.Width + margin, 0);

			this.Width = labelSuffix.Location.X + labelSuffix.Width;

			this.BackColor = bgColor;
			tbCount.BackColor = bgColor;
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

		private void Form1_KeyDown (object sender, KeyEventArgs e)
		{
			Console.WriteLine("Key pressed: " + e.KeyCode.ToString());

			if (e.KeyCode == incrementKey)
				currentNumber++;
			else if (e.KeyCode == decrementKey)
				currentNumber--;

			tbCount.SelectAll();
			tbCount.SelectionAlignment = HorizontalAlignment.Center;

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


		#endregion

		#region File control

		#region Counter file

		string countExt = "splc";

		private void saveCounterTSM_Click(object sender, EventArgs e)
		{
			//OFD parametres
			OpenFileDialog fd = new OpenFileDialog
			{
				DefaultExt = countExt,
				Title = "Save count file",
				CheckFileExists = false,
				Filter = "count files (*." + countExt + ")|*." + countExt
			};

			if (fd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(fd.FileName))
				{
					sw.WriteLine(currentNumber);
					sw.WriteLine(incrementKey.ToString());
					sw.WriteLine(decrementKey.ToString());
				}
			}
			fd.Dispose();
		}

		private void loadCounterTSM_Click(object sender, EventArgs e)
		{
			//OFD parametres
			OpenFileDialog fd = new OpenFileDialog
			{
				DefaultExt = countExt,
				Title = "Load count file",
				CheckFileExists = true,
				Filter = "count files (*." + countExt + ")|*." + countExt
			};

			Console.WriteLine();
			Console.WriteLine("################################################");
			Console.WriteLine("#              New counter loaded              #");
			Console.WriteLine("################################################");
			Console.WriteLine();

			if (fd.ShowDialog() == DialogResult.OK)
			{
				using (StreamReader sr = new StreamReader(fd.FileName))
				{
					if (!int.TryParse(sr.ReadLine(), out currentNumber))
						currentNumber = 0;
					Console.WriteLine("Current count: " + currentNumber);

					if (!Enum.TryParse(sr.ReadLine(), out incrementKey))
						incrementKey = Keys.I;
					Console.WriteLine("Increment key: " + incrementKey.ToString());

					if (!Enum.TryParse(sr.ReadLine(), out decrementKey))
						decrementKey = Keys.K;
					Console.WriteLine("Decrement key: " + decrementKey.ToString());
				}

				currentCounterFile = fd.FileName;

				updateGUI();
			}
			fd.Dispose();
		}

		#endregion

		#region Layout file

		string layoutExt = "spll";
		private void saveLayoutTSM_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog
			{
				DefaultExt = layoutExt,
				Title = "Save Layout",
				CheckFileExists = false,
				Filter = "Layout files (*." + layoutExt + ")|*." + layoutExt
			};

			if (fd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(fd.FileName))
				{
					sw.WriteLine(prefix);
					sw.WriteLine(suffix);
					sw.WriteLine(bgColor.ToArgb().ToString());
				}
			}
			fd.Dispose();
		}

		private void loadLayoutTSM_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog
			{
				DefaultExt = layoutExt,
				Title = "Load layout",
				CheckFileExists = true,
				Filter = "Layout files (*." + layoutExt + ")|*." + layoutExt
			};

			if (fd.ShowDialog() == DialogResult.OK)
			{
				int argbColor;

				Console.WriteLine();
				Console.WriteLine("################################################");
				Console.WriteLine("#              New layout loaded               #");
				Console.WriteLine("################################################");
				Console.WriteLine();

				using (StreamReader sr = new StreamReader(fd.FileName))
				{
					prefix = sr.ReadLine();
					Console.WriteLine("Prefix: " + prefix);

					suffix = sr.ReadLine();
					Console.WriteLine("Suffix: " + suffix);

					if (!int.TryParse(sr.ReadLine(), out argbColor))
						argbColor = -1;
					Console.WriteLine("Background color: " + Color.FromArgb(argbColor).ToString() + ", int value: " + argbColor);
				}
				bgColor = Color.FromArgb(argbColor);

				currentLayoutFile = fd.FileName;

				updateGUI();
			}
			fd.Dispose();
		}

		#endregion

		#endregion

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
			ColorDialog cd = new ColorDialog
			{
				AnyColor = true,
				AllowFullOpen = true,
				FullOpen = true
			};

			if (cd.ShowDialog() == DialogResult.OK)
            {
				bgColor = cd.Color;
				updateGUI();
            }
			cd.Dispose();
        }

        private void exitToolStripMenuItem_Click (object sender, EventArgs e)
		{
			//Exit button
			Application.Exit();
		}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (!string.IsNullOrEmpty(currentCounterFile))
            {
				if (MessageBox.Show("Would you like to save your counter?") == DialogResult.OK)
                {
					using (StreamWriter sw = new StreamWriter(currentCounterFile))
                    {
						sw.WriteLine(currentNumber);
						sw.WriteLine(incrementKey.ToString());
						sw.WriteLine(decrementKey.ToString());
					}
                }
            }

			if (!string.IsNullOrEmpty(currentLayoutFile))
            {
				if (MessageBox.Show("Would you like to save your layout?") == DialogResult.OK)
                {
					using (StreamWriter sw = new StreamWriter(currentLayoutFile))
					{
						sw.WriteLine(prefix);
						sw.WriteLine(suffix);
						sw.WriteLine(bgColor.ToArgb().ToString());
					}
				}
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void tbCount_Enter(object sender, EventArgs e)
        {
			textBox1.Focus();

			Focus();
        }
    }
}
