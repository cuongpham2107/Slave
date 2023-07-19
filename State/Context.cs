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
        public ChromeOptions Options;
        public Context()
        {
            currentState = new LoggedOutGoogle();
        }
        public void SetState(BaseState state){
            currentState = state;
        }
        public void ExecuteState(){
            currentState.Execute(this);
        }
    }
}
