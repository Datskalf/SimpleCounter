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
	public partial class PrefixSuffix : Form
	{
		public PrefixSuffix ()
		{
			InitializeComponent();
		}

		public string prefix = "";
		public string suffix = "";

		private void buttonSubmit_Click (object sender, EventArgs e)
		{

		}

		private void buttonExit_Click (object sender, EventArgs e)
		{

		}

		private void TextBox_TextChanged (object sender, EventArgs e)
		{
			prefix = textBoxPrefix.Text;
			suffix = textBoxSuffix.Text;
		}
	}
}
