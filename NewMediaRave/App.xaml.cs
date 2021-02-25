using NewMediaRave.Data;
using NewMediaRave.Services;
using NewMediaRave.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewMediaRave
{
    public partial class App : Application
    {
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            //handle when app starts
        }

        protected override void OnSleep()
        {
            //handle when  app sleeps
        }

        protected override void OnResume()
        {

            //handle when app resumes
        }

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }
        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }
    }
}
