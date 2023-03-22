using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Project
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string Name { get; set; }

    public string Summary { get; set; }

    public string Conclusion { get; set; }

    public string IndexKeys { get; set; }

    public int? MedCaseNum { get; set; }

    public int? MedCaseExpectedNum { get; set; }

    public int? TaskNum { get; set; }

    public byte? AutoBind { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? LastUpdateTime { get; set; }

    public int? AddUserId { get; set; }
}
