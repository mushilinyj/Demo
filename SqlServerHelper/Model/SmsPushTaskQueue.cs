using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class SmsPushTaskQueue
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int InterviewId { get; set; }

    public int RemindingWho { get; set; }

    /// <summary>
    /// 发短信任务是成功还是失败  0 失败 1 成功
    /// </summary>
    public byte Status { get; set; }

    public DateTime AddTime { get; set; }

    public int? SendUserId { get; set; }
}
