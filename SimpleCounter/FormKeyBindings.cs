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
	public partial class FormKeyBindings : Form
	{
		public FormKeyBindings (Form1 form1)
		{
			InitializeComponent();
			parent = form1;
		}


		Form1 parent;

		public Keys IncrementKey;
		public Keys DecrementKey;


		private void FormKeyBindings_Load (object sender, EventArgs e)
		{
			IncrementKey = parent.incrementKey;
			DecrementKey = parent.decrementKey;

			textBoxIncrement.Text = IncrementKey.ToString();
			textBoxDecrement.Text = DecrementKey.ToString();
		}

		private void textBox_TextChanged (object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			switch (tb.Text.Length)
			{
				case 0:
					buttonSubmit.Enabled = false;
					break;
				case 1:
					buttonSubmit.Enabled = true;
					tb.Text = tb.Text.ToUpper();
					break;
				case 2:
					buttonSubmit.Enabled = true;
					tb.Text = tb.Text.Substring(1).ToUpper();
					tb.SelectionStart = tb.Text.Length;
					break;
			}
		}

		private void buttonSubmit_Click (object sender, EventArgs e)
		{
			Enum.TryParse(textBoxIncrement.Text, out IncrementKey);
			Enum.TryParse(textBoxDecrement.Text, out DecrementKey);
		}
	}
}
