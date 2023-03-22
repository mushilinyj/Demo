using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseMessageAuth
{
    public int Id { get; set; }

    public string VerifyToken { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    public int InterviewId { get; set; }

    public int MedCaseId { get; set; }

    public DateTime DeadlineTime { get; set; }

    public DateTime AddTime { get; set; }
}
