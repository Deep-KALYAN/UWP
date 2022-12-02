using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Activite3UWP.MVVM.ViewsModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        // Implémentation de l'interface 'INotifyPropertyChanged'
        public event PropertyChangedEventHandler PropertyChanged;

        // Méthode qui va émettre l'événement 'PropertyChanged' pour les Views. Le nom de 
        // la propriété est passé par le système (c'est le nom de l'appelant)
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
