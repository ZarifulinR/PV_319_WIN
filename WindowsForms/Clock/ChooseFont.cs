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
using System.Collections;
using System.Drawing.Text;
namespace Clock
{

	public partial class ChooseFontForm : Form
	{
		public ChooseFontForm()
		{
			InitializeComponent();
		}

		private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedState = cbFonts.SelectedItem.ToString();
			Font font =new Font(selectedState, 12.0f);
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(selectedState);
			foreach(Control c in this.Controls)
			{
				c.Font = new Font(pfc.Families[0],10 , FontStyle.Regular);
			}
		}

		private void cbFonts_DropDown(object sender, EventArgs e)
		{
			string[] files = Directory.GetFiles("..\\..\\Fonts", "*.ttf", SearchOption.AllDirectories);
			foreach (string fnt in files)
			{
				FileInfo fileInfo = new FileInfo(fnt.Split('\\').Last());
				string filename = fileInfo.ToString();
				
				cbFonts.Items.Add(filename);

			}
			
		}

		private void labelExample_ControlAdded(object sender, ControlEventArgs e)
		{
			
		}
		
		
	}
}
