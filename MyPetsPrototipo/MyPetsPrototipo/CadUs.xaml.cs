using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyPetsPrototipo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadUs : ContentPage
    {
        public CadUs()
        {
            InitializeComponent();
        }

        async void merda(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }



    }
}