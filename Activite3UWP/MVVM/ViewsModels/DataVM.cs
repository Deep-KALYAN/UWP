
using Activite3UWP.MVVM.ViewsModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Activite3UWP
{  
    public class DataVM : ViewModelBase
    {
       // private DataM _dataModel = new DataM();


        private  ObservableCollection<BOReply> _replies = new ObservableCollection<BOReply>();

        public ObservableCollection<BOReply> Replies
        {
            get { return _replies; }
            set { _replies = value; }
        }
        public async void GetReplies(int id)
        {
            Replies.Clear();
            var replies = await DataM.Instance.GetRepliesByTopicId(id);
            if (replies != null)
            {
                replies.ForEach(x => Replies.Add(x));
            }
        }

        private  ObservableCollection<BOTopic> _topics = new ObservableCollection<BOTopic>();

        public ObservableCollection<BOTopic> Topics
        {
            get { return _topics; }
            set { _topics = value; }
        }
      

        public async void GetTopics(int id)
        {
            var topicsList = await DataM.Instance.GetTopicsByRubId(id);
            Topics.Clear();
            Replies.Clear();
            if (topicsList != null)
            {
            topicsList.ForEach(x => Topics.Add(x));
            }
        }
    }
}
