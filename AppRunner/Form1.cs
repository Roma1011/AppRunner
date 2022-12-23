using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppRunner
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void RunnerBt_Click(object sender, EventArgs e)
		{
			string input = Count.Text;
			bool isValid = true;
			foreach (char c in input)
			{
				if (!char.IsDigit(c))
				{
					isValid = false;
					break;
				}
			}
			if (isValid)
			{
				int result = int.Parse(input);
				for(int i=0;i<result;i++)
				{
					Process firstProc = new Process();
					firstProc.StartInfo.FileName = WhayBox.Text;
					firstProc.EnableRaisingEvents = true;
					firstProc.Start();
				}
			}
			else
			{
				MessageBox.Show("Cannot Run", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
