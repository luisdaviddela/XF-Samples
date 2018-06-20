using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LDXF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ej3 : ContentPage
	{
		public Ej3 ()
		{
			InitializeComponent ();
            yu.Items.Add("xsluis");
		}
	}
}