using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12Library
{
    public class Client
    {        
        public void SubscribeNews(NewsProvider newsProvider)
        {
            newsProvider.News += new NewsProvider.NewsWriter(Print); 
        }
        public void SubscribeWeather(NewsProvider newsProvider)
        {
            newsProvider.Weather += new NewsProvider.NewsWriter(Print);
        }
        public void SubscribeSports(NewsProvider newsProvider)
        {
            newsProvider.Sports += new NewsProvider.NewsWriter(Print);
        }
        public void SubscribeAccidents(NewsProvider newsProvider)
        {
            newsProvider.Accidents += new NewsProvider.NewsWriter(Print);
        }
        public void SubscribeHumor(NewsProvider newsProvider)
        {
            newsProvider.Humor += new NewsProvider.NewsWriter(Print);
        }
        private void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
