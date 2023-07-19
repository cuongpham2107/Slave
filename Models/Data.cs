namespace Slave{
    public class Data{
        public string Email {get;set;}
        public string Password {get;set;}
        public int TimeToWatchVideo {get;set;}
        public string[] Keywords {get;set;}
        public string[] Channels {get;set;}
        public string[] Urls{get;set;}
        public string[] Comments{get;set;}
        public string[] Icons {get;set;}
        /// <summary>
        /// Kich ban
        /// </summary>
        public int Script {get;set;}
       
        public Data(string email, string password,int timeToWatchVideo, string[] keywords, string[] channels, string[] urls, string[] comments, string[] icons,int script){
            Email = email;
            Password = password;
            TimeToWatchVideo = timeToWatchVideo;
            Keywords = keywords;
            Channels = channels;
            Urls = urls;
            Comments = comments;
            Icons = icons;
            Script = script;
        }
    }
}