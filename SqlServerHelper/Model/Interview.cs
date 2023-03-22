using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Interview
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string Name { get; set; }

    public byte Active { get; set; }

    /// <summary>
    /// 1即时随访2定时随访3节日关怀4纪念日问候
    /// </summary>
    public byte? Model { get; set; }

    public string FestivalDate { get; set; }

    public int? IndexDictId { get; set; }

    public int Sort { get; set; }

    public int? Step { get; set; }

    public TimeSpan? Time { get; set; }

    public byte PushQuestion { get; set; }

    /// <summary>
    /// 0关闭1开启短信提醒功能
    /// </summary>
    public byte Sms { get; set; }

    /// <summary>
    /// 推送的时间与计划的时间是否必须同一天，1为是，0表示推送的时间可以晚于计划时间，仍然补推
    /// </summary>
    public byte RemindOnSameDay { get; set; }

    public string RemindingContent { get; set; }

    /// <summary>
    /// 0是患者1是医生
    /// </summary>
    public byte RemindingWho { get; set; }

    public DateTime AddTime { get; set; }

    public int? SubmitType { get; set; }

    public int? RemindMode { get; set; }

    public int Wechat { get; set; }

    public int ResendTimes { get; set; }
}
