//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: HttpClientExtensions
// 创建时间: 2019/1/9 10:20:11
// 创 建 人: 范根强
//==================================================
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace simple.dotnetcore.http.Extensions
{
    /// <summary>
    /// HttpClient 扩展
    /// </summary>
    public static class HttpClientExtensions
    {
        /// <summary>
        ///  以异步的方式将 POST 请求发送到指定的 URI
        /// </summary>
        /// <typeparam name="TResponse">返回结果类型</typeparam>
        /// <param name="client">HttpClinet</param>
        /// <param name="requestUri">请求地址</param>
        /// <param name="value">请求参数</param>
        /// <param name="authValue">身份验证信息</param>
        /// <returns>返回结果</returns>
        public static async Task<TResponse> PostAsJsonAsync<TResponse>(this HttpClient client, string requestUri,
            object value, AuthenticationHeaderValue authValue)
        {
            var content = JsonConvert.SerializeObject(value);
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json")
            };

            if (authValue != null)
            {
                request.Headers.Authorization = authValue;
            }

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResponse>(json);
        }
    }
}
