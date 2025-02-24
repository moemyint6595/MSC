using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCShared.Modal
{
    public class Manga
    {
        public string _id { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string coverImage { get; set; } = string.Empty;
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int __v { get; set; }
    }

    public class MangaEpisode
    {
        public string _id { get; set; } = string.Empty;
        public string episode_name { get; set; } = string.Empty;
        public string manga_id { get; set; } = string.Empty;
        public string free_date { get; set; } = string.Empty;
        public bool is_free { get; set; }
        public string quality { get; set;} = string.Empty;
        public int __v { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class MangaImage
    {
        public string _id { get; set; } = string.Empty;
        public string manga_id { get; set; } = string.Empty;
        public string manga_episode_id { get; set; } = string.Empty;
        public string image_url { get; set; } = string.Empty;
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int __v { get; set; }
    }

    public class User : UserPost
    {
        public string _id { get; set; } = string.Empty;
    }

    public class UserPost
    {
        public string user_name { get; set; } = string.Empty;
        public string image_url { get; set; } = string.Empty;

        public bool is_vip { get; set; }

        public string vip_expire_date { get; set; } = string.Empty;

        public string device_name { get; set; } = string.Empty;

        public string device_id { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string phone { get; set; } = string.Empty;
    }

    public class UserImageParam
    {
        public string user_name { get; set; } = string.Empty;
        public string image_url { get; set; } = string.Empty;
    }

    public class LoginPost
    {
        public string user_name { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string device_id { get; set; } = string.Empty;
    }

    public class LoginStatus
    {
        public string message { get; set; } = string.Empty;

        public string status { get; set; } = string.Empty;
    }

    public class FavManga
    {
        public string _id { get; set; } = string.Empty;
        public string coverImage { get; set; } = string.Empty;
    }

    public class SearchManga
    {
        public string _id { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string coverImage { get; set; } = string.Empty;
    }

    public class CurrentMangaEpi
    {
        public string manga_id { get; set; } = string.Empty;

        public string episoide_id { get; set; } = string.Empty;
    }

}