using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehrereEreignisse
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void rBtnRot_CheckedChanged(object sender, EventArgs e)
		{
			//if (rBtnRot.Checked) lblAmpel.ForeColor = Color.Red;
			//if (rBtnGelb.Checked) lblAmpel.ForeColor = Color.Yellow;
			//if (rBtnGrün.Checked) lblAmpel.ForeColor = Color.Green;
		}

		private void AmpelfarbeGeändert(object sender, EventArgs e)
		{
			if (rBtnRot.Checked) lblAmpel.ForeColor = Color.Red;
			if (rBtnGelb.Checked) lblAmpel.ForeColor = Color.Yellow;
			if (rBtnGrün.Checked) lblAmpel.ForeColor = Color.Green;
		}

	}
}
