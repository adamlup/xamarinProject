using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarinProjekt.Objects;
using xamarinProjekt.ViewModels;

namespace xamarinProjekt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel mvModel;
        public MainPage()
        {
            InitializeComponent();

            mvModel = new MainViewModel();
            FactsListView.ItemsSource = mvModel.catFactsList;
        }
    }
}