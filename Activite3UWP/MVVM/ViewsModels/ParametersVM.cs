using Activite3UWP.MVVM.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
namespace Activite3UWP
{
    class ParametersVM : ViewModelBase
    {
        private string _httpAdress = ApplicationData.Current.LocalSettings.Values["HttpAdress"] as string;
        public string HttpAdress
        {
            get
            {
                return _httpAdress;
            }

            set
            {
                _httpAdress = value;
                RaisePropertyChanged(); // Permet de notifier la View d'une modification
            }
        }
    }
}

//namespace Activite3UWP.MVVM.ViewsModels
//{
//    class ParametersVM : ViewModelBase
//    {
//        #region Reply

//        //ChildReplyText
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //CR_CreatorNickName
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //ChildReplyDate
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //ParentReplyText
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //PR_CreatorNickName
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //ParentReplyDate
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //ChildReplyId
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //CR_CreatorId
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }


//        //ParentReplyId
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //PR_CreatorId
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //TopicId
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //Child_Reply_Deleted
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //TopicViews
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        #endregion

//        #region Topic

//        //TopicTitle
//        private string _childReplyText = ApplicationData.Current.LocalSettings.Values["ChildReplyText"] as string;
//        public string ChildReplyText
//        {
//            get
//            {
//                return _childReplyText;
//            }

//            set
//            {
//                _childReplyText = value;
//                RaisePropertyChanged(); // Permet de notifier la View d'une modification
//            }
//        }

//        //TopicText

//        //TopicCreatorNickName

//        //TopicPublishedDate

//        //RubricId

//        //RubricName

//        //TopicId
//        #endregion









//    }
//}
