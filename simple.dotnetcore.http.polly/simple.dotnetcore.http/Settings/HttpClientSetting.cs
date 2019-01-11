//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: HttpClientSetting
// 创建时间: 2019/1/9 9:45:03
// 创 建 人: 范根强
//==================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace simple.dotnetcore.http.Settings
{
    /// <summary>
    /// 配置httpclient
    /// </summary>
    public class HttpClientSetting
    {
        /// <summary>
        /// 请求的优先级
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// 请求的基地址
        /// </summary>
        public string BaseAddress { get; set; }

        /// <summary>
        /// Http处理程序集合
        /// </summary>
        public List<string> DelegatingHandlers { get; set; }

        /// <summary>
        /// Http 处理程序生存期，默认2分钟 
        /// </summary>
        public int? HandlerLifetime { get; set; }

        /// <summary>
        /// Http错误处理政策集合
        /// </summary>
        public List<string> ErrorPolicies { get; set; }
    }
}
