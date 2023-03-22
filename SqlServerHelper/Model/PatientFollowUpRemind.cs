using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class PatientFollowUpRemind
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int InterviewId { get; set; }

    public int ProjectId { get; set; }

    public int MedCaseId { get; set; }

    public DateTime? AddTime { get; set; }
}
