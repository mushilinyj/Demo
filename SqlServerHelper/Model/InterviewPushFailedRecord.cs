using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class InterviewPushFailedRecord
{
    public int Id { get; set; }

    public int? MedCaseId { get; set; }

    public int? InterviewId { get; set; }

    public byte? RemindingWho { get; set; }

    public string OpenId { get; set; }

    public string ErrorMsg { get; set; }

    public int? SendUserId { get; set; }

    public DateTime? AddTime { get; set; }

    public string PushMode { get; set; }

    public string Remark { get; set; }
}
