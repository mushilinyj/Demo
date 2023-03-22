using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectMedCaseDelRecord
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int ProjectId { get; set; }

    public DateTime AddTime { get; set; }

    public int GroupId { get; set; }

    public int OperUserId { get; set; }
}
