using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using WebApplication.Business.Abstract;
using WebApplication.Extensions.LocalStorage;

namespace WebApplication.Infrastructer
{
    public class AuthTokenHandler : DelegatingHandler
    {
        private readonly ISyncLocalStorageService _syncLocalStorageService;

        public AuthTokenHandler(ISyncLocalStorageService syncLocalStorageService)
        {
            _syncLocalStorageService = syncLocalStorageService;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_syncLocalStorageService != null)
            {
                var token = _syncLocalStorageService.GetToken();
                request.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}
