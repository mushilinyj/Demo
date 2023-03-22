using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class InterviewPushQueue
{
    public int Id { get; set; }

    public int? MedCaseId { get; set; }

    public int? InterviewId { get; set; }

    public byte? RemindingWho { get; set; }

    public DateTime? AddTime { get; set; }
}
