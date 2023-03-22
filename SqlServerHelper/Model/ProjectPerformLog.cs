using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectPerformLog
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    /// <summary>
    /// 0：表示排出，1表示纳入
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// 0：表示手动执行，1：表示自动执行
    /// </summary>
    public int Mode { get; set; }

    public string PerformCaseId { get; set; }

    public int PerformCaseCount { get; set; }

    public DateTime? PerformTime { get; set; }

    public int ProjectOutinQueryId { get; set; }

    public string QueryDescribe { get; set; }

    public int? OperUserId { get; set; }
}
