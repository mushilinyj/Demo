using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseSmsStatusQueue
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int InterviewId { get; set; }

    public int RemindingWho { get; set; }

    public string CustomMsgId { get; set; }

    public int Status { get; set; }

    public DateTime AddTime { get; set; }
}
