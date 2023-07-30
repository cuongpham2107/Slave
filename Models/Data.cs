namespace Slave{
    public class Data{
        public string Email {get;set;}
        public string Password {get;set;}
        public int TimeToWatchVideo {get;set;}
        public List<Keywords> Keywords {get;set;}
        public string[] Channels {get;set;}
        public string[] Urls{get;set;}
        public string[] Comments{get;set;}
        public string[] Icons {get;set;}
        public Data(string email, string password,int timeToWatchVideo, List<Keywords> keywords, string[] channels, string[] urls, string[] comments, string[] icons){
            Email = email;
            Password = password;
            TimeToWatchVideo = timeToWatchVideo;
            Keywords = keywords;
            Channels = channels;
            Urls = urls;
            Comments = comments;
            Icons = icons;
        }
    }
    public class Keywords
    {
        public string? Keyword { get; set; }
        public int Status { get; set; }
    }
}