using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPetsPrototipo
{
    public partial class App : Application
    {
       
        public NavigationPage CadUs { get; set; }
        public CarouselPage Page1 { get; set; }

       
        public App()
        {
            InitializeComponent();


            //MainPage = new MainPage();

            MainPage = new NavigationPage(new MainPage());
            CadUs = new NavigationPage(new CadUs());
           

            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new Page1());
            carouselPage.Children.Add(new CadPets());

            Page1 = carouselPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
