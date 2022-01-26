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

			Content = new Panel { BackgroundColor = Colors.DarkGray };

			Content.MouseUp += (o, e) => {

				var form = new Form() { 
					ShowInTaskbar = false, WindowStyle = WindowStyle.None,
					Content = new GroupBox() { Text = "GroupBox" },
				};

				form.Location = this.Location + this.Size / 3;
				form.Size = this.Size / 3;

				form.Show();
			};
		}
	}
}
