using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCasePerformLog
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int ProjectId { get; set; }

    public int GroupId { get; set; }

    /// <summary>
    /// 0：排出，1：纳入
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// 0：手动执行，1：自动执行
    /// </summary>
    public int Mode { get; set; }

    public DateTime? OperationTime { get; set; }

    public int ProjectOutinQueryId { get; set; }

    public int ProjectPerformLogId { get; set; }

    public string QueryDescribe { get; set; }

    public int? OperUserId { get; set; }
}
