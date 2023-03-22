using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class InterviewPushRecordView
{
    public int? MedCaseId { get; set; }

    public int? InterviewId { get; set; }

    public int ProjectId { get; set; }

    public int Type { get; set; }

    public DateTime? AddTime { get; set; }
}
