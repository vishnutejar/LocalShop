using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalShop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ValidateUser(object sender, EventArgs e)
        {
            String email, pasword;
            email = entryemail.Text;
            pasword = entrypassword.Text;
            if (string.IsNullOrEmpty(email))
            {

                DisplayAlert("Validation Error", "Enter Your Email", "ok");
            }
            else if (string.IsNullOrEmpty(pasword))
            {
                DisplayAlert("Validation Error", "Enter Your password", "ok");

            }
            else {

                //User authenticated
                App.Current.MainPage=new NavigationPage( new HomePage());

            }

        }

        private void GoToForgotPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void GoToSignUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}