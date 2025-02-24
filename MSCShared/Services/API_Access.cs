using MSCShared.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MSCShared.Services
{
    public class API_Access
    {
        private VariableService _gva;
        private HttpClient _httpClient;
        public API_Access(VariableService gva, HttpClient httpClient)
        {
            _gva = gva;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Manga>?> GetMangaList()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Manga>>($"{_gva.BaseURL}/manga");
        }

        public async Task<Manga?> GetMangaAsync(string manga_id)
        {
            return await _httpClient.GetFromJsonAsync<Manga>($"{_gva.BaseURL}/manga/{manga_id}");
        }

        public async Task<IEnumerable<MangaEpisode>?> GetEpisodes(string manga_id)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<MangaEpisode>>($"{_gva.BaseURL}/mangaepisode/mangaid/{manga_id}");
        }

        public async Task<IEnumerable<MangaImage>?> GetMangaImages(string manga_id, string manga_episode_id)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<MangaImage>>($"{_gva.BaseURL}/mangaimage/{manga_id}/{manga_episode_id}");
        }
        public async Task<UserPost?> CreateUser(UserPost data)
        {
            var response = await _httpClient.PostAsJsonAsync<UserPost>($"{_gva.BaseURL}/user/add", data);

            return await response.Content.ReadFromJsonAsync<UserPost>();
        }

        public async Task<UserPost?> GetUserByUserName(string username)
        {
            return await _httpClient.GetFromJsonAsync<UserPost>($"{_gva.BaseURL}/user/getbyusername/{username}");
        }

        public async Task<LoginStatus?> UserLogin(LoginPost data)
        {

            var response = await _httpClient.PostAsJsonAsync<LoginPost>($"{_gva.BaseURL}/user/login", data);

            return await response.Content.ReadFromJsonAsync<LoginStatus>();
        }

        public async Task<string?> UpdateUserImageAsync(UserImageParam param)
        {
            var response = await _httpClient.PutAsJsonAsync<UserImageParam>($"{_gva.BaseURL}/user/updateimage", param);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string?> GetDeviceIdAsync(string username)
        {
            return await _httpClient.GetStringAsync($"{_gva.BaseURL}/user/getdeviceid/{username}");
        }

        public async Task<IEnumerable<SearchManga>?> GetSearchMangaAsync(string search_param)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<SearchManga>>($"{_gva.BaseURL}/manga/search/{search_param}");
        }

        public async Task<string?> IsUserAlreadyExist(string username)
        {
            return await _httpClient.GetStringAsync($"{_gva.BaseURL}/user/usernameunique/{username}");
        }
    }
}
