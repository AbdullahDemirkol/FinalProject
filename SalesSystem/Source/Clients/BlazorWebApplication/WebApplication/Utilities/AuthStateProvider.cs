using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication.Extensions.LocalStorage;
using WebApplication.Infrastructer;

namespace WebApplication.Utilities
{
    public class AuthStateProvider: AuthenticationStateProvider
    {

        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _httpClient;
        private readonly AuthenticationState _authenticationState;
        private readonly StateManager _stateManager;

        public AuthStateProvider(ILocalStorageService localStorageService, HttpClient httpClient, StateManager stateManager)
        {
            _localStorageService = localStorageService;
            _httpClient = httpClient;
            _authenticationState = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            _stateManager = stateManager;
        }
        public void UserLogin(string userName,DateTime expiration)
        {
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.Expiration,expiration.ToString())
            }, "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(claimsPrincipal));
            NotifyAuthenticationStateChanged(authState);
            _stateManager.LoginChanged(null);
        }
        public void UserLogout()
        {
            var authState = Task.FromResult(_authenticationState);
            NotifyAuthenticationStateChanged(authState);
            _stateManager.LoginChanged(null);
        }
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string apiToken = await _localStorageService.GetToken();
            if (string.IsNullOrEmpty(apiToken))
            {
                return _authenticationState;
            }

            string userName = await _localStorageService.GetUsername();
            string expiration = await _localStorageService.GetExpiration();

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name,userName),
                new Claim(ClaimTypes.Expiration,expiration)


            }, "jwtAuthType"));

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
            return new AuthenticationState(claimsPrincipal);
        }
    }
}
