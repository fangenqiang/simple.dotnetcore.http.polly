//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: HttpClientPriority
// 创建时间: 2019/1/9 10:02:46
// 创 建 人: 范根强
//==================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace simple.dotnetcore.http.Priority
{
    /// <summary>
    /// 用于http请求优先级
    /// </summary>
    public enum HttpClientPriority
    {
        /// <summary>
        /// 百度基地址
        /// </summary>
        BaiduNormal = 1,
        /// <summary>
        /// 淘宝基地址
        /// </summary>
        TaobaoNormal = 2,
        /// <summary>
        /// 腾讯基地址
        /// </summary>
        TencentNormal = 3
    }
}
