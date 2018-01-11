using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HApp
{
    public partial class MainPage : ContentPage
    {
         
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            //Entry UserName_Entry = new Entry
            //{
            //    Text = txtUsername.Text.Trim()
            //};
            //Entry Password_Entry = new Entry
            //{
            //    Text = txtPassword.Text.Trim()
            //};
            //UserName_Entry = txtUsername;
            //Password_Entry = txtPassword;
            var UText = txtUsername.Text;
            var PText = txtPassword.Text;

            if (UText == null || UText == "")
            {
                lblLoginStatus.Text = "Username should not be empty";
                lblLoginStatus.TextColor = Color.Red;
            }
            else
            {
                if (PText == null || PText == "")
                {
                    lblLoginStatus.Text = "Password should not be empty";
                    lblLoginStatus.TextColor = Color.Red;
                }
                else if (UText == PText)
                {
                    Device.BeginInvokeOnMainThread(() => Application.Current.MainPage = new NavigationPage(new MainTabbedPage()));
                }
                else
                {
                    lblLoginStatus.Text = "Username and Password doesn't match!!";
                    lblLoginStatus.TextColor = Color.Red;
                }
            } 
        }
    }
}
