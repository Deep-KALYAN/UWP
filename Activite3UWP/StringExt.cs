using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace Activite3UWP
{
    public static class StringExt
    {
        public static string Localize(this string key)
        {
            return ResourceLoader.GetForCurrentView("Messages").GetString(key);
        }
    }
}
