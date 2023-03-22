using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class InterviewWaitingToSend
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int InterviewId { get; set; }

    public DateTime InterviewDate { get; set; }

    public byte InterviewWho { get; set; }

    public int MedCaseId { get; set; }
}
