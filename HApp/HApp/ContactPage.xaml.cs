using HApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        ShelterViewModel SVM;
        public ContactPage()
        {
            InitializeComponent();
            SVM = new ShelterViewModel();
            //listShelters.ItemsSource = SVM.Shelters;
            //In XAML the Binding item source is done 
            BindingContext = SVM;
        }

        private async void btnRegisterForShelter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationForShelterPage());
        }
    }
}