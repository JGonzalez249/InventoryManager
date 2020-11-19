using InventoryManager.Data;
using System.ComponentModel;

namespace InventoryManager.WinForm.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }
     
        public World World { get; set; }
    }
}
