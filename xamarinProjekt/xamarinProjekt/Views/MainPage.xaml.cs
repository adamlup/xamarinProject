using System;
using System.Collections.Generic;
using System.Linq;
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
        public string Name { get; set; } = "LISTA ELEMENTÓW";
        public MainPage()
        {
            InitializeComponent();

            MainViewModel mvModel = new MainViewModel();
            //mvModel.AddElmToList(new ListElements("elm1"));
            //mvModel.AddElmToList(new ListElements("elm2"));
            //mvModel.AddElmToList(new ListElements("elm3"));
            //mvModel.AddElmToList(new ListElements("elm4"));
            listaListView.ItemsSource = mvModel.listOfStrings;
        }
    }
}