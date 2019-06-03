using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamls.Data;
using Xamls.Models;
using Xamls.ViewModels;

namespace Xamls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingPage : ContentPage
    {
        ContactListViewModel contactListViewModel;

        public DataBindingPage()
        {
            contactListViewModel = new ContactListViewModel();
            BindingContext = contactListViewModel;
            InitializeComponent();

        }

        private void ContactList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Contact;

            if (item != null) {
                DisplayAlert("Aha", string.Format("You have selected {0} {1}", item.FirstName, item.LastName), "Ok");
            }
        }
    }
}