using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectLockMedCase
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    public string MedCaseId { get; set; }

    public DateTime Addtime { get; set; }

    public int AddUserId { get; set; }
}
