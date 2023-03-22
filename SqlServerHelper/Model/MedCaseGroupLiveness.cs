using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseGroupLiveness
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int GroupId { get; set; }

    public DateTime AddTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public string OpenId { get; set; }

    public int Level { get; set; }
}
