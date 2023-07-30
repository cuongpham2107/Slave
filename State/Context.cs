using Mype.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Slave
{
    public class Context
    {   
        // private BaseState currentState;
        public Data Data;
        public IWebDriver Driver;
        public Context(IWebDriver driver, Data data)
        {
            Driver = driver;
            Data = data;
        }
        // public void SetState(BaseState state){
        //     currentState = state;
        // }
        // public void ExecuteState(){
        //     currentState.Execute(this);
        // }
        public void ScriptChannelsState()
        {
            List<BaseState> ListState = new List<BaseState>{
                new LoggedOutGoogle(),
                new VideoSearchYoutobe(),
                new ChooseVideoYoutobe(),
                new PlayingVideoYoutobe(),
                new LikeVideoYoutobe(),
                new SubVideoYoutobe(),
                new CommentVideoYoutobe(),
                new NextVideoToChannelYoutobe(),
            };
           
            foreach (var item in ListState)
            {
                item.Execute(this);
            }
        }
        public void ScriptUrlsState(){
            List<BaseState> ListState = new List<BaseState>{
                new LoggedOutGoogle(),
                new VideoSearchYoutobe(),
                new ChooseVideoYoutobe(),
                new PlayingVideoYoutobe(),
                new LikeVideoYoutobe(),
                new SubVideoYoutobe(),
                new CommentVideoYoutobe(),
                new NextVideoToUrlYoutobe(),
            };
           
            foreach (var item in ListState)
            {
                item.Execute(this);
            }
        }
    }
}
