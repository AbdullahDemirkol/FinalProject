﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Extensions.LocalStorage;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using WebApplicationAdminPanel.Business.Abstract;
using WebApplicationAdminPanel.Entity.Concrete.User;
using WebApplicationAdminPanel.Extensions.ClientHttp;
using WebApplicationAdminPanel.Utilities;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using Microsoft.AspNetCore.Components;
using WebApplicationAdminPanel.Entity.Concrete.Helper;

namespace WebApplicationAdminPanel.Business.Concrete
{
    public class IdentityManager:IIdentityService
    {
        private readonly HttpClient _httpClient;
        private readonly ISyncLocalStorageService _syncLocalStorageService;
        private readonly AuthenticationStateProvider _authStateProvider;

        public IdentityManager(HttpClient httpClient, ISyncLocalStorageService syncLocalStorageService, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _syncLocalStorageService = syncLocalStorageService;
            _authStateProvider = authStateProvider;
        }
        public async Task<bool> Login(string userName, string password)
        {
            var request = new LoginRequest(userName, password);
            var response = await _httpClient.PostGetResponseAsync<LoginResponse, LoginRequest>("Auth/Login", request);
            if (response != null)
            {
                if (response.RoleName == "admin")
                {

                    if (!string.IsNullOrEmpty(response.UserToken))
                    {
                        _syncLocalStorageService.SetToken(response.UserToken);
                        _syncLocalStorageService.SetUsername(response.UserName);
                        _syncLocalStorageService.SetExpiration(response.Expiration);
                        ((AuthStateProvider)_authStateProvider).UserLogin(response.UserName, response.Expiration);
                        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", response.UserName);
                        return true;
                    }
                }
            }
            return false;
        }
        public void Logout()
        {
            _syncLocalStorageService.RemoveItem("token");
            _syncLocalStorageService.RemoveItem("username");
            _syncLocalStorageService.RemoveItem("expiration");
            ((AuthStateProvider)_authStateProvider).UserLogout();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
        public bool IsLoggedIn => !string.IsNullOrEmpty(GetUserToken());

        public string GetUsername()
        {
            var userName = _syncLocalStorageService.GetUsername();
            return userName;
        }

        public string GetUserToken()
        {
            var token = _syncLocalStorageService.GetToken();
            return token;
        }
        public string GetUserExpiration()
        {
            var expiration = _syncLocalStorageService.GetExpiration();
            return expiration;
        }
        public User GetUserModel(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                User userModel = new User();
                userModel.Username = securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                userModel.FirstName = securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value.Split(' ')[0];
                userModel.LastName = securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value.Split(' ')[1];
                userModel.Email = securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                userModel.Phone = securityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.MobilePhone)?.Value;
                return userModel;
            }
            catch (Exception)
            {
                //TODO: Logger.Error
                return null;
            }
        }
        public async Task<PaginatedViewModel<User>> GetUsers(int pageIndex=0,int pageSize=6)
        {
            var query =$"auth/users?pageIndex={pageIndex}&pageSize={pageSize}";
            var user = await _httpClient.GetResponseAsync<PaginatedViewModel<User>>(query);
            return user;
        }
        public async Task<bool> RemoveUser(int userId)
        {
            var query = $"auth/SetUserStatus/{userId}";
            var result= await _httpClient.PostGetStringResponseAsync<bool>(query,false);
            return result == "İşleminiz Başarılı" ? true : false ;
        }

        public async Task<List<Role>> GetRoles()
        {
            var role = await _httpClient.GetResponseAsync<List<Role>>("auth/roles");
            return role;
        }
        public async Task<bool> AddUser(UserDTO addUserModel,int roleId)
        {
            var query = $"auth/AddUser/{roleId}";
            var isAddedUser = await _httpClient.PostGetResponseAsync<bool, UserDTO>(query, addUserModel);
            return isAddedUser;
        }
        public async Task<bool> UpdateUser(UserDTO updateUserModel, string newPas)
        {
            var query = $"auth/UpdateUser/";
            if (!string.IsNullOrEmpty(newPas))
            {
                query += newPas;
            }
            else
            {
                query += "null";
            }
            var isUpdatedUser = await _httpClient.PostGetResponseAsync<bool, UserDTO>(query, updateUserModel);
            return isUpdatedUser;
        }
    }
}
