//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: InjectBaiduHandler
// 创建时间: 2019/1/11 14:08:56
// 创 建 人: 范根强
//==================================================
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace simple.dotnetcore.http.Handlers
{
    /// <summary>
    /// baidu handler
    /// </summary>
    public class InjectBaiduHandler: DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            //自定义headers
            //byte[] bytes = Encoding.UTF8.GetBytes($"{_appId}:{_appSecret}");
            //string value = Convert.ToBase64String(bytes);
            //if (request.Headers.Authorization == null)
            //{
            //    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", value);
            //}
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
