namespace HW12Library
{
    public class NewsProvider
    {
        
        public string news { get; set; }
        public string weather { get; set; }
        public string sports { get; set; }
        public string accidents { get; set; }
        public string humor { get; set; }
        
        public delegate void NewsWriter(string value);
        public event NewsWriter News;
        public event NewsWriter Weather;
        public event NewsWriter Sports;
        public event NewsWriter Accidents;
        public event NewsWriter Humor;
        public void AddNews(string value)
        {
            news = value;
            News (news);
        }
        public void AddWeather (string value)
        {
            weather = value;
            Weather (weather);
        }
        public void AddSports (string value)
        {
            sports = value;
            Sports (sports);
        }
        public void AddAccidents (string value)
        {
            accidents = value;
            Accidents (accidents);
        }
        public void AddHumor (string value)
        {
            humor = value;
            Humor (humor);
        }
        

    }
}