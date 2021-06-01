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
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void SendPassword(object sender, EventArgs e)
        {
            string email;
            email = entryEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                DisplayAlert("Validation Error", "Enter your Email", "ok");
            }
            else { 
            
                //Send a password to his mail id
            }

        }
    }
}