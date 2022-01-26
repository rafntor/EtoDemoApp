using Eto.Drawing;
using Eto.Forms;
using System;

namespace EtoDemoApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			Title = "My Eto Form";
			Size = new Size(3, 2) * 200;

			var listbox = new ListBox();
			for (int i=0; i<40; ++i)
			{
				listbox.Items.Add($"item with longish text {i}");
			}

			var layout = new DynamicLayout();
			layout.AddRow(listbox, new Panel());

			Content = layout;
		}
	}
}
