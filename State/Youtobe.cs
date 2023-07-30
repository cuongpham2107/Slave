using System;

namespace Slave
{
    public class VideoSearchYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            List<Keywords> keywords = context.Data.Keywords;
            SeleniumHelper s = new SeleniumHelper(context.Driver);
            s.GoToUrl("https://www.youtube.com");
            foreach (Keywords keyword in keywords)
            {
                if(keyword.Status == 0){
                    Extensions.WriteLine("Tìm kiếm từ khoá video", ConsoleColor.Blue);
                    s.SearchVideo(keyword.Keyword!);
                    keyword.Status = 1;
                    break;
                }
            }
        }
    }
    public class ChooseVideoYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            SeleniumHelper s = new SeleniumHelper(context.Driver);
            Extensions.WriteLine("Chọn video", ConsoleColor.Blue);
            s.ChooseVideo();
            //context.SetState(new PlayingVideoYoutobe());
        }
    }
    public class PlayingVideoYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            int time =  context.Data.TimeToWatchVideo;
            SeleniumHelper s = new SeleniumHelper(context.Driver);
             Extensions.WriteLine("Xem video", ConsoleColor.Blue);
            s.PlayingVideo(time);
            //context.SetState(new LikeVideoYoutobe());
        }
    }
    public class LikeVideoYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            SeleniumHelper s = new SeleniumHelper(context.Driver);
            s.LikeVideo();
            //context.SetState(new SubVideoYoutobe());
        }
    }
    public class SubVideoYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            SeleniumHelper s = new SeleniumHelper(context.Driver);
            s.SubVideo();
            //context.SetState(new CommentVideoYoutobe());
        }
    }
    public class CommentVideoYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            string[] comments = context.Data.Comments;
            string[] icons = context.Data.Icons;
            SeleniumHelper s = new SeleniumHelper(context.Driver);
            s.CommentVideo(comments,icons);
            //context.SetState(new NextVideoToChannelYoutobe());
        }
    }
    public class NextVideoToUrlYoutobe : BaseState
    {
         public void Execute(Context context)
        {
            string[] urls = context.Data.Urls;
            var statesToExecute = new List<BaseState>
            {
                new PlayingVideoYoutobe(),
                new LikeVideoYoutobe(),
                new SubVideoYoutobe(),
                new CommentVideoYoutobe()
            };
            foreach (var url in urls)
            {
                SeleniumHelper s = new SeleniumHelper(context.Driver);
                Extensions.WriteLine("Chọn video tiếp theo", ConsoleColor.Blue);
                bool check =  s.NextVideoToUrl(url);
                if(check){
                    foreach (var state in statesToExecute)
                    {
                        state.Execute(context);
                    }
                }else{
                    Extensions.WriteLine($"Không tìm thấy video {url} này ", ConsoleColor.Yellow);
                }
                
            }
        }
    }
    public class NextVideoToChannelYoutobe : BaseState
    {
        public void Execute(Context context)
        {
            string[] channels = context.Data.Channels;
            var statesToExecute = new List<BaseState>
            {
                new PlayingVideoYoutobe(),
                new LikeVideoYoutobe(),
                new SubVideoYoutobe(),
                new CommentVideoYoutobe()
            };
            foreach (var channel in channels)
            {
                SeleniumHelper s = new SeleniumHelper(context.Driver);
                Extensions.WriteLine("Chon video tiep theo", ConsoleColor.Blue);
                s.NextVideoToChannel(channel);

                foreach (var state in statesToExecute)
                {
                    state.Execute(context);
                }
            }
        }
    }
}