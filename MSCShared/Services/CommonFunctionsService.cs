using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MSCShared.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MSCShared.Services
{
    public class CommonFunctionsService
    {
        NavigationManager _Nav;
        IJSRuntime _jSRuntime;
        NotifierService _notifier;
        VariableService _gva;
        LocalStorageService _localStorageService;
        //API_Access _API_Access;
        public CommonFunctionsService(NavigationManager nav, IJSRuntime jSRuntime, NotifierService notifierService, VariableService variableService, LocalStorageService localStorageService) 
        { 
            _Nav = nav;
            _jSRuntime = jSRuntime;
            _notifier = notifierService;
            _gva = variableService;
            _localStorageService = localStorageService;
            //_API_Access = _D;
        }
        public void GotoRoute(string route)
        {
            _Nav.NavigateTo(route);
        }
        public void GotoRouteWithQueryParams(string route, Dictionary<string, object?> Queryparams)
        {
            _Nav.NavigateTo(_Nav.GetUriWithQueryParameters(route, Queryparams));
        }

        public async Task SetBackgoundImage(string imgUrl)
        {
            _gva.BgImgUrl = imgUrl;
            await _notifier.Update(NotifierEmitNames.BackgoundChange, "", imgUrl);
        }

        public void JSConsole(object? obj, string? title = null)
        {
            _jSRuntime.InvokeVoidAsync("console.log", $"{title} =>" , obj );
        }

        public void Loading(bool toggle)
        {
            _jSRuntime.InvokeVoidAsync("CommonJSFunctions.ToggleLoading", toggle);
        }

        //public void ShowError(string? message = null)
        //{
        //    if (string.IsNullOrEmpty(message))
        //    {
        //        message = "Something is wrong";
        //    }
        //    _jSRuntime.InvokeVoidAsync("CommonJSFunctions.ShowErrorMessage", message);
        //}

        public void CLoseError()
        {
            _jSRuntime.InvokeVoidAsync("CommonJSFunctions.CloseErrorMessage");
        }

        public async Task LogOut()
        {
            await _localStorageService.RemoveItem(LocalStorageKey.Login);
            ResetTask();
            GotoRoute("/login");
        }

        public async Task GetUserFavList()
        {
            try
            {
                if (_gva.AuthInfo is not null)
                {
                    Console.Write(UserNameToKey(_gva.AuthInfo.user_name) + LocalStorageKey.Favourite);
                    _gva.UserFavDict = await _localStorageService.GetItem<Dictionary<string,FavManga>>(UserNameToKey(_gva.AuthInfo.user_name) + LocalStorageKey.Favourite);
                }
            }
            catch (Exception ex)
            {
                //ShowError(ex.Message);
            }
        }

        public async Task ToggleUserFavManga(Manga manga)
        {
            try
            {
                if (_gva.AuthInfo is not null)
                {
                    if (_gva.UserFavDict is null) _gva.UserFavDict = new();
                    if (_gva.UserFavDict.ContainsKey(manga._id))
                    {
                        _gva.UserFavDict.Remove(manga._id);
                    }
                    else
                    {
                        var favManga = new FavManga()
                        {
                            _id = manga._id,
                            coverImage = manga.coverImage
                        };
                        _gva.UserFavDict.Add(manga._id, favManga);
                    }
                    await _localStorageService.SetItem<Dictionary<string, FavManga>>(UserNameToKey(_gva.AuthInfo.user_name) + LocalStorageKey.Favourite, _gva.UserFavDict);
                }
            }
            catch (Exception ex)
            {
                //ShowError(ex.Message);
            }
        }

        public void Focus(string inputId)
        {
            _jSRuntime.InvokeVoidAsync("CommonJSFunctions.Focus", inputId);
        }

        public string UserNameToKey(string username)
        {
            return username.Replace(" ","").ToLower() + "_";
        }

        public async Task FillManga()
        {
            if(_gva.MangaList is null || !_gva.MangaList.Any())
            {
                //_gva.MangaList = await _API_Access.GetMangaList();
            }
        }

        public bool ContainsOnlyDigits(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        public async Task SetAuthInfo()
        {
            //if (_gva.isAuth) return;
            var authData = await _localStorageService.GetItem<UserPost?>(LocalStorageKey.Login);
            if(authData is not null)
            {
                //_gva.AuthInfo = await _API_Access.GetUserByUserName(authData.user_name);
                //if(_gva.AuthInfo is not null )
                //{
                //    //_gva.IsVIP = _gva.AuthInfo.is_vip;
                //    //_gva.isAuth = true;
                //    await _localStorageService.SetItem<UserPost>(LocalStorageKey.Login, _gva.AuthInfo);
                //}
                //else
                //{
                //    _gva.AuthInfo = null;
                //    //_gva.IsVIP = false;
                //    //_gva.isAuth = false;
                //}
            }
            else
            {
                _gva.AuthInfo = null;
                //_gva.IsVIP = false;
                //_gva.isAuth = false;
            }
        }

        public void GotoContact()
        {
            _Nav.NavigateTo("/contact");
        }

        private void ResetTask()
        {
            //_gva.IsVIP = false;
            _gva.BgImgUrl = string.Empty;
            _gva.AuthInfo = new();
            _gva.UserFavDict = null;
            _gva.UserFaveMangaList = null;
        }
    }
}
