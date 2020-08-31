using System.Collections.Generic;
using System.Collections.ObjectModel;
using xamarinProjekt.Objects;

namespace xamarinProjekt.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<ListElements> listOfStrings = new ObservableCollection<ListElements>();
        public ObservableCollection<ListElements> listToBind { get { return listOfStrings; } }
        
        public MainViewModel()
        {
            listOfStrings.Add(new ListElements { Element = "elm1" });
            listOfStrings.Add(new ListElements { Element = "elm2" });
            listOfStrings.Add(new ListElements { Element = "elm3" });
            listOfStrings.Add(new ListElements { Element = "elm4" });
        }
    }  
}