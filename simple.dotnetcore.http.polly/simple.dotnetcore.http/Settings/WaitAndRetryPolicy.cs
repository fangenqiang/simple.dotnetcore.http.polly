//==================================================
// Copyright (C) 2016-2019 Fanjia
// All rights reserved
// CLR 版本: 4.0.30319.42000
// 机器名称: PC-20180807FPRA
// 文 件 名: WaitAndRetryPolicy
// 创建时间: 2019/1/9 10:08:58
// 创 建 人: 范根强
//==================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace simple.dotnetcore.http.Settings
{
    /// <summary>
    /// 用于存储 HTTP 错误等待后重试处理的政策参数
    /// </summary>
    public class WaitAndRetryPolicy
    {
        /// <summary>
        /// 等待重试的时间间隔，单位为毫秒
        /// </summary>
        public int[] SleepDurations { get; set; }
    }
}
