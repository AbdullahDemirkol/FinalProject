﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Extensions.ClientHttp
{
    public static class HttpClientExtension
    {
        public async static Task<TResult> PostGetResponseAsync<TResult, TValue>(this HttpClient client, string url, TValue value)
        {
            var httpRes = await client.PostAsJsonAsync(url, value);
            if (httpRes.IsSuccessStatusCode)
            {
                return await httpRes.Content.ReadFromJsonAsync<TResult>();
            }
            return default;
        }
        public async static Task PostAsync<TValue>(this HttpClient client, string url, TValue value)
        {
            await client.PostAsJsonAsync(url, value);
        }
        public async static Task<T> GetResponseAsync<T>(this HttpClient client, string url)
        {
            var x= await client.GetFromJsonAsync<T>(url);
            return x;
        }
    }
}
