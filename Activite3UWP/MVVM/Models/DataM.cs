
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Activite3UWP
{
    public class DataM
    {

      //  HttpClient _client = new HttpClient();

        private static volatile DataM _instance;
        private static readonly object _syncRoot = new Object();
        private readonly HttpClient _httpClient = new HttpClient();
        private DataM()
        {
            //Singleton = constructeur privé
        }
        public static DataM Instance //Propriété static pour créer I'instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot) // Verrou pour les accès multi threads
                    {
                        if (_instance == null)
                        {
                            _instance = new DataM();
                        }
                    }
                }
                return _instance;
            }
        }
        public async Task<List<BOTopic>> GetTopicsByRubId(int id)
        {

            //Uri uri = new Uri($"{ApplicationData.Current.LocalSettings.Values["HttpAdress"]}/api/rubric/{id}/topics"); /// new Uri($" { ApplicationData.Current.LocalSettings.Values["HttpAdress"]}/api/rubric/{id}/topics");

            using (var res = await _httpClient.GetAsync($"http://localhost:5000/api/rubric/{id}/topics")) //uri); //
            {

                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsStringAsync();


                    var lstDTOTopics = JsonSerializer.Deserialize<List<GetRubricsAndTopicsDetailResponseDTO>>(content);

                    return lstDTOTopics.ConvertAll(u => new BOTopic
                    {
                        TopicTitle = u.TopicTitle,
                        TopicText = u.TopicText,
                        TopicCreatorNickName = u.TopicCreatorNickName,
                        TopicPublishedDate = u.TopicPublishedDate,
                        RubricId = u.RubricId,
                        RubricName = u.RubricName,
                        TopicId = u.TopicId,
                    });
                }
                
            }
                    return null;
               
        }



        public async Task<List<BOReply>> GetRepliesByTopicId(int id)
        {
          //  Uri uri = new Uri($" { ApplicationData.Current.LocalSettings.Values["HttpAdress"]}/api/topic/{id}/detail");

            var res = await _httpClient.GetAsync($"http://localhost:5000/api/topic/{id}/detail");

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();


                var lstDTOReplies = JsonSerializer.Deserialize<List<GetTopicRepliesDetailResponseDTO>>(content);

                return lstDTOReplies.ConvertAll(u => new BOReply
                {
                    TopicId = u.TopicId,
                    TopicViews = u.TopicViews,
                    ChildReplyId = u.ChildReplyId,
                    ChildReplyText = u.ChildReplyText,
                    ChildReplyDate = u.ChildReplyDate,
                    Child_Reply_Deleted = u.Child_Reply_Deleted,
                    CR_CreatorId = u.CR_CreatorId,
                    CR_CreatorNickName = u.CR_CreatorNickName,
                    ParentReplyId = u.ParentReplyId,
                    ParentReplyText = u.ParentReplyText,
                    ParentReplyDate = u.ParentReplyDate,
                    PR_CreatorId = u.PR_CreatorId,
                    PR_CreatorNickName = u.PR_CreatorNickName,
                    ColorReply = (u.Child_Reply_Deleted) ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Green),
                    PreplyT_F = (u.PR_CreatorId != null) ? true : false,
                });
            }
            else
            {
                return null;
            }
        }

    }
}

