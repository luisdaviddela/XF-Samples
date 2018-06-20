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
	public partial class RegisterSample : ContentPage
	{
        string facebookLD = "https://www.facebook.com/luis.davidela";
        string googlePlus = "https://plus.google.com/u/0/102503921281035162051";
        string twitterLD = "https://twitter.com/Luisdavidela";
        string LinkedInLD = "https://www.linkedin.com/in/luis-david-de-la-cruz-bautista-a02b42114";

		public RegisterSample ()
		{
			InitializeComponent ();
            var fbLink = new TapGestureRecognizer();
            fbLink.Tapped += (s, e) => {
                visitFacebook();
            };
            fb.GestureRecognizers.Add(fbLink);

            var googleLink = new TapGestureRecognizer();
            googleLink.Tapped += (s, e) => {
                VisitGoogle();
            };
            gp.GestureRecognizers.Add(googleLink);

            var twitterLink = new TapGestureRecognizer();
            twitterLink.Tapped += (s, e) => {
                visitTwitter();
            };
            tw.GestureRecognizers.Add(twitterLink);

            var linkedInLink = new TapGestureRecognizer();
            linkedInLink.Tapped += (s, e) => {
                visitLinkedIn();
            };
            li.GestureRecognizers.Add(linkedInLink);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            SexPick.Items.Add("Masculino");
            SexPick.Items.Add("Femenino");
        }

        void visitFacebook()
        {

            try
            {
                Device.OpenUri(new Uri(facebookLD));
            }
            catch (Exception)
            {

                throw;
            }
        }
        void VisitGoogle()
        {

            try
            {
                Device.OpenUri(new Uri(googlePlus));
            }
            catch (Exception)
            {

                throw;
            }
        }
        void visitTwitter()
        {

            try
            {
                Device.OpenUri(new Uri(twitterLD));
            }
            catch (Exception)
            {

                throw;
            }
        }
        void visitLinkedIn()
        {

            try
            {
                Device.OpenUri(new Uri(LinkedInLD));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}