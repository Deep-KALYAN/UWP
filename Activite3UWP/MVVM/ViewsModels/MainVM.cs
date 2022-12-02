using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activite3UWP.MVVM.ViewsModels
{
    class MainVM : ViewModelBase
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        private string _audio = "Audio";
        private string _logout = "Logout";
        private string _title = "AMIO Developers Forum";
        public string Audio { get { return _audio; } set { _audio = value; RaisePropertyChanged(); } }

        public string Logout { get { return _logout; } set { _logout = value; RaisePropertyChanged(); } }
        public string Title { get { return _title; } set { _title = value; RaisePropertyChanged(); } }
    }
}
