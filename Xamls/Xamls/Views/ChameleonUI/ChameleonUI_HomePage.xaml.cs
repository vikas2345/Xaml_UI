using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamls.Views.ChameleonUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChameleonUI_HomePage : ContentPage
	{
		public ChameleonUI_HomePage ()
		{
			InitializeComponent ();
		}

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            DisplayAlert("Label has been swiped", "", "Ok");
        }
    }
}