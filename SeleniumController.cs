using System;
using Mype.ConsoleMvc;
using Mype.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Slave
{
	class SeleniumController
	{
        static ConfigChrome _config = ConfigManager<ConfigChrome>.Instance.Config;
        [Route("test")]
		public static void Run()
		{
            string email = "quynhdonghy2001@gmail.com";
            string password = "Cuonggiun1";
            string profileId = "64b7a5f105cb2d2f16fdd1cb";
            int timeToWatchVideo = 2;
            string[] keywords = {
                "Tạo Bảng Chấm công và Chấm công với danh sách nhân viên, Tạo và Cập nhập Object sử dụng Devexpress",
                "Phần mềm quản lý - Sử dụng Devexpress XAF, Build 2 nền tảng Web và Win cùng 1 code logic",
                "Tạo Calendar chấm công bằng PopupWindowShowAction trong Devexpress",
                "Phần mềm quản lý đề tài khoa học công nghệ, Sử dụng C#",
                "Cách sử dụng và chạy phần mềm quản lý Kho sử dụng Dev                                                                                                                                                                                                                                                                   express Xaf",
                 "Add module google map in Devexpress XAF Blazor",
            };
            string[] channels = {
                "Phạm Mạnh Cường",
                "Em Chè ĐTCL",
                "LCK Tiếng Việt",
                "VieTalents",
                "TUI TÊN BÔ",
                "VieShows",
            };
            string[] urls = {
                "watch?v=13wbFpF8jdc",
                "watch?v=CRCmbMT3LRw",
                "watch?v=kqqTCoTSsmQ",
                "watch?v=vB7KTj7rH4w",
                "watch?v=A_SWGE5LmJo",
                "watch?v=RRtP40txW0Y"
            };
            string[] comments = {
                "Video này thực sự tuyệt vời! Tôi rất ấn tượng với cách nó truyền đạt thông điệp sâu sắc và truyền cảm hứng.",
                "Các hình ảnh và âm nhạc được lựa chọn tốt và tạo ra một trải nghiệm tuyệt vời",
                "Cảm ơn vì đã chia sẻ video này! Nó cung cấp một cái nhìn sâu sắc và phản ánh tốt vấn đề mà nó đề cập.",
                "Tôi rất thích cách thông điệp được truyền tải một cách rõ ràng và đầy sức mạnh.",
                "Video này thật đặc biệt! Nó đã khơi dậy trong tôi những cảm xúc sâu sắc và đồng thời mang lại kiến thức mới.",
                "Đạo diễn đã làm rất tốt trong việc kết hợp các yếu tố hình ảnh, âm thanh và lời thoại để tạo nên một tác phẩm tuyệt vời.",
                "Tôi không thể ngừng xem video này! Nó rất cuốn hút và đã tạo ra một trải nghiệm thú vị.",
                "Những hình ảnh đẹp mắt và cốt truyện sáng tạo khiến nó trở thành một video đáng để xem và chia sẻ."
            };
            string[] icons = {
                "<3 <3 <3",
                ":)))",
                "=)))",
                ":3",
                "^^ ^^",
                ":v",
                ";-) ;)",
                ":-O"
            };
            int script = 1;
            //Data data = new Data(email, password, timeToWatchVideo,keywords, urls, channels, comments,icons);
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = _config.BinaryLocation;
            options.AddArgument(_config.UserDataDir.Replace("{id}", profileId));
            options.AddArgument(_config.Extension.Replace("{id}", profileId));
            options.AddArguments("--disable-default-apps", "--disable-extensions");
            options.AddArguments(_config.Arguments);
            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Position = new System.Drawing.Point(0, 0);
            driver.Manage().Window.Size = new System.Drawing.Size(450, 450);

            // Tạo đối tượng Context và đặt các giá trị cần thiết vào Data
            var context = new Context(driver, new Data(email, password, timeToWatchVideo, keywords, channels, urls, comments, icons, script));
            //context.ExecuteState();
            while (true)
            {
                context.ExecuteState();
            }
        }
	}
}

