//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: RetryPolicy
// 创建时间: 2019/1/9 10:08:22
// 创 建 人: 范根强
//==================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace simple.dotnetcore.http.Settings
{
    /// <summary>
    /// 用于存储 HTTP 错误重试处理的政策参数
    /// </summary>
    public class RetryPolicy
    {
        /// <summary>
        /// 重试次数
        /// </summary>
        public int RetryCount { get; set; }
    }
}
