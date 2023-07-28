using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Slave
{
    public class LoggedOutGoogle : BaseState
    {
        public void Execute(Context context)
        {
            string email = context.Data.Email;
            string password = context.Data.Password;
            SeleniumHelper s = new SeleniumHelper(context.Driver);
            s.GoToUrl("http://accounts.google.com");
            bool checkLogin = s.LoginGoogle(email, password);
            if(checkLogin){
                //context.SetState(new VideoSearchYoutobe());
                Console.WriteLine("Chuyen sang trang thai tim kiem video");
                
            }
            else{
                //Post Api thong bao loi dang nhap google
                //context.SetState(new LoggedOutGoogle());
            }
        }
    }
}