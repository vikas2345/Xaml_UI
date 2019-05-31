using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamls.Models;

namespace Xamls.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
        Contact contact;

		public DataBindingPage ()
		{
            BindingContext = this;
			InitializeComponent ();
            contact = new Contact { FirstName = "Vikas", LastName="Singh", Email="hello@xam.com"};
		}

        private void ContactList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}