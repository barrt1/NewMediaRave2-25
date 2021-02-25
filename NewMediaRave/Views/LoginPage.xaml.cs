using NewMediaRave.Models;
using NewMediaRave.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewMediaRave.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            StyleColors();
            this.BindingContext = new LoginViewModel();

        }


        void StyleColors()
        {
            BackgroundColor = Constants.BackdropColor;
            Lbl_UserName.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            Btn_Signin.BackgroundColor = Constants.ButtonColor;

        }

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Success!", "Okay");
            }
            else
            {
                DisplayAlert("Login", "Error: Please enter a username and password.", "Okay");
            }
        }

    }

}