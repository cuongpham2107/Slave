using Mype.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Slave
{
    public class Context
    {   
        private BaseState currentState;
        public Data Data;
        public IWebDriver Driver;
        public Context(IWebDriver driver, Data data)
        {
            Driver = driver;
            Data = data;
            ScriptState(this);
        }
        public void SetState(BaseState state){
            currentState = state;
        }
        public void ExecuteState(){
            currentState.Execute(this);
        }
        public void ScriptState(Context context)
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
                item.Execute(context);
            }
        }
    }
}
