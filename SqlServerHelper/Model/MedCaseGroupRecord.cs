using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseGroupRecord
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int GroupId { get; set; }

    public int IndexDictId { get; set; }

    public string UpdateValue { get; set; }

    public string UpdateWaya { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateTime { get; set; }
}
