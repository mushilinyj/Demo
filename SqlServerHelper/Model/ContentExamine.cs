using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ContentExamine
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int? ProjectId { get; set; }

    public int? InterviewId { get; set; }

    public string Content { get; set; }

    public string ErrorMsg { get; set; }

    /// <summary>
    /// 审查状态:0待审1通过2不过
    /// </summary>
    public byte Status { get; set; }

    public int SubmitUserId { get; set; }

    public DateTime SubmitTime { get; set; }

    public int? ExamineUserId { get; set; }

    public DateTime? ExamineTime { get; set; }
}
