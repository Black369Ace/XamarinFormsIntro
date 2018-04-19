using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsIntro
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{

        public QuotesPage()
        {
            InitializeComponent();
        }


        static int FontSize = 5;


            List<string> school = new List<string>()
            {
                "F is for friends who do stuff together",
                "U is for you and me",
                "N is for anywhere, anytime at all",
                "Down here in the deep blue sea!"
            };


            Label rotationLabel = new Label
            {
                Text = "Font Size" + FontSize;
            }
	}
}