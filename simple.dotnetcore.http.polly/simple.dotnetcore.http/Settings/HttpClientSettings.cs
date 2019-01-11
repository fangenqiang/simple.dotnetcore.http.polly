//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: HttpClientSettings
// 创建时间: 2019/1/9 9:45:10
// 创 建 人: 范根强
//==================================================
using System.Collections.Generic;


namespace simple.dotnetcore.http.Settings
{
    /// <summary>
    /// httpclient配置集合
    /// </summary>
    public class HttpClientSettings
    {
        /// <summary>
        /// Http请求关键程度枚举类型
        /// </summary>
        public string PriorityType { get; set; }
        /// <summary>
        /// Http请求基地址键值对集合
        /// </summary>
        public Dictionary<string, string> BaseAddresses { get; set; }
        /// <summary>
        /// Http 处理程序键值对集合
        /// </summary>
        public Dictionary<string, string> DelegatingHandlers { get; set; }

        /// <summary>
        /// Http 错误等待后重试处理政策的键值对集合
        /// </summary>
        public Dictionary<string, RetryPolicy> RetryPolicies { get; set; }

        /// <summary>
        /// HTTP 错误等待后重试处理政策的键值对集合
        /// </summary>
        public Dictionary<string, WaitAndRetryPolicy> WaitAndRetryPolicies { get; set; }
        /// <summary>
        /// HTTP 错误断路处理政策的键值对集合
        /// </summary>
        public Dictionary<string, CircuitBreakerPolicy> CircuitBreakerPolicies { get; set; }
        /// <summary>
        /// Http 配置集合
        /// </summary>
        public List<HttpClientSetting> Settings { get; set; }
    }
}
