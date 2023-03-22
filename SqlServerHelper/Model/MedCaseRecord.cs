using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseRecord
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int? MedCaseNodePropertyId { get; set; }

    public int? IndexDictId { get; set; }

    public string UpdateValue { get; set; }

    public string UpdateWay { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }
}
