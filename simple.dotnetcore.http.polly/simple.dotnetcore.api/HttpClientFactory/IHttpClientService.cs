using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using simple.dotnetcore.http.Priority;

namespace simple.dotnetcore.api.HttpClientFactory
{
    public interface IHttpClientService
    {
        /// <summary>
        /// 使用指定类型创建的 <see cref="System.Net.Http.HttpClient"/> 以异步的方式将 POST 请求发送到指定的 URI
        /// </summary>
        /// <typeparam name="TResponse">返回结果类型</typeparam>
        /// <param name="priority"><see cref="System.Net.Http.HttpClient"/> 请求的关键程度</param>
        /// <param name="requestUri">请求地址</param>
        /// <param name="value">请求参数</param>
        /// <param name="authorization">身份验证信息</param>
        /// <returns>返回结果</returns>
        Task<TResponse> PostAsJsonAsync<TResponse>(HttpClientPriority priority,
            string requestUri, object value, AuthenticationHeaderValue authorization = null);

        /// <summary>
        /// 使用指定名称创建的 <see cref="System.Net.Http.HttpClient"/> 以异步的方式将 POST 请求发送到指定的 URI
        /// </summary>
        /// <typeparam name="TResponse">返回结果类型</typeparam>
        /// <param name="name">用于创建 <see cref="System.Net.Http.HttpClient"/> 的名称</param>
        /// <param name="requestUri">请求地址</param>
        /// <param name="value">请求参数</param>
        /// <param name="authorization">身份验证信息</param>
        /// <returns>返回结果</returns>
        Task<TResponse> PostAsJsonAsync<TResponse>(string name, string requestUri, object value,
            AuthenticationHeaderValue authorization = null);
    }
}
