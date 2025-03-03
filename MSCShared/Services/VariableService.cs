using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSCShared.Modal;

namespace MSCShared.Services
{
    public class VariableService
    {
        //public bool IsVIP, isAuth;

        public string BaseURL = "https://msc-server.onrender.com/api";

        public string BgImgUrl = string.Empty;

        public UserPost? AuthInfo;

        public List<FavManga>? UserFaveMangaList;

        public Dictionary<string, FavManga>? UserFavDict;

        public string DeviceId = string.Empty;
        public IEnumerable<Manga>? MangaList { get; set; }

    }

    public struct NotifierEmitNames
    {
        public const string BackgoundChange = "backgoundchange";

        public const string ProfileChange = "profilechange";
    }

    public struct LocalStorageKey
    {
        public const string Login = "msc_login";

        public const string Favourite = "msc_fav";

        public const string recentSearch = "msc_recent_s";

        public const string DeviceId = "msc_device_id";

        public const string CurrentManga = "msc_cur_magepi";
    }

    public struct Status
    {
        public const string Success = "s";

        public const string Fail = "f";
    }

    public readonly struct Menu
    {
        public const string BookList = "/mangalist";
        public const string Favourite = "/favourite";
        public const string Download = "/download";
        public const string Userinfo = "/userinfo";
        public const string Contact = "/contact";
        public const string Search = "/search";
    }
}
