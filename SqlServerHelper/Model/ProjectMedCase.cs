using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectMedCase
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int MedCaseId { get; set; }

    public DateTime? DateRangeFrom { get; set; }

    public DateTime? DateRangeTo { get; set; }

    public DateTime? AddTime { get; set; }
}
