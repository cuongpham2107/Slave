
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slave
{
    public class ConfigChrome
    {
        public string BinaryLocation { get; set; } = "/Users/phamcuong/.gologin/browser/orbita-browser-113/Orbita-Browser.app/Contents/MacOS/Orbita";
        public string UserDataDir { get; set; } = "--user-data-dir=/tmp/gologin_074247d264/profiles/{id}";
        public string Extension { get; set; } = "--load-extension=/Users/phamcuong/.gologin/extensions/cookies-ext/{id},/Users/phamcuong/.gologin/extensions/passwords-ext/{id}";
        public string[] Arguments { get; set; } = new[] { "--font-masking-mode=2", "--profile-directory=Default", "--disable-encryption", "--donut-pie=undefined", "--lang=en-US", "--flag-switches-begin", "--flag-switches-end" };
    }
    public class ConfigYoutobe
    {
        public string ButtonIconSearch { get; set; } = "/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/yt-icon-button/button";
        public string ButtonClearSearch {get;set;} = ".yt-spec-button-shape-next.yt-spec-button-shape-next--text.yt-spec-button-shape-next--mono.yt-spec-button-shape-next--size-m.yt-spec-button-shape-next--icon-only-default";
        public string InputSearch { get; set; } = "search_query";
        public string FirstVideo { get; set; } = "a.yt-simple-endpoint.style-scope.ytd-video-renderer";
        public string LikeVideo { get; set; } = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-watch-metadata/div/div[2]/div[2]/div/div/ytd-menu-renderer/div[1]/ytd-segmented-like-dislike-button-renderer/yt-smartimation/div/div[1]/ytd-toggle-button-renderer/yt-button-shape/button";
        public string SubscribeVideo { get; set; } = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-watch-metadata/div/div[2]/div[1]/div/ytd-subscribe-button-renderer/yt-smartimation/yt-button-shape/button";
        public string Commnent { get; set; } = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-comments/ytd-item-section-renderer/div[1]/ytd-comments-header-renderer/div[5]/ytd-comment-simplebox-renderer/div[1]";
        public string InputComment { get; set; } = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-comments/ytd-item-section-renderer/div[1]/ytd-comments-header-renderer/div[5]/ytd-comment-simplebox-renderer/div[3]/ytd-comment-dialog-renderer/ytd-commentbox/div[2]/div/div[2]/tp-yt-paper-input-container/div[2]/div/div[1]/ytd-emoji-input/yt-user-mention-autosuggest-input/yt-formatted-string/div";
        public string ButtonComment { get; set; } = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-comments/ytd-item-section-renderer/div[1]/ytd-comments-header-renderer/div[5]/ytd-comment-simplebox-renderer/div[3]/ytd-comment-dialog-renderer/ytd-commentbox/div[2]/div/div[4]/div[5]/ytd-button-renderer[2]/yt-button-shape/button";
        public string ChannelTabsRight { get; set; } = "a.yt-simple-endpoint.style-scope.ytd-compact-video-renderer";
        public string LinkTabsRight { get; set; } = "a.yt-simple-endpoint.style-scope.ytd-compact-video-renderer";
        public string ChannelCurrent { get; set; } = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-watch-flexy/div[5]/div[1]/div/div[2]/ytd-watch-metadata/div/div[2]/div[1]/ytd-video-owner-renderer/div[1]/ytd-channel-name/div/div/yt-formatted-string/a";
    }
    /// <summary>
    /// 
    /// </summary>
    public class ConfigGoogle
    {
        /// <summary>
        /// Input gmail Login
        /// </summary>
        public string InputEmailGoogle { get; set; } = "identifierId";
        /// <summary>
        /// Input password Login
        /// </summary>
        public string IntputPasswordGooogle { get; set; } = "Passwd";
        /// <summary>
        /// Nội dung "Đăng nhập" ở màn hình login
        /// </summary>
        public string CheckLogin { get; set; } = "a.gb_d.gb_Ha.gb_x";
        /// <summary>
        /// Element Chon tai khoan google
        /// </summary>
        public string ChooseUserGoogle {get;set;} = "li.JDAKTe.eARute.W7Aapd.zpCp3.SmR8";
    }
}