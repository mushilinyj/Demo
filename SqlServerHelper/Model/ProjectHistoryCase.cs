using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectHistoryCase
{
    public int MedCaseId { get; set; }

    public int ProjectId { get; set; }

    public DateTime? AddTime { get; set; }

    public int Status { get; set; }
}
