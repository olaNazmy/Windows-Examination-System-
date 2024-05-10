using exam_app.Models;

namespace exam_app
{
	public partial class Form1 : Form
	{
		ItidbContext ItidbContext { get; set; } = new ItidbContext();
		public Form1()
		{
			InitializeComponent();
			
		}
	}
}
