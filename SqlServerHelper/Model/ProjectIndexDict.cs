using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectIndexDict
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int IndexDictId { get; set; }

    public int Sort { get; set; }

    public string Range { get; set; }

    public string Remark { get; set; }

    public string ChartType { get; set; }

    public byte? Alert { get; set; }

    public byte? InFollowUp { get; set; }

    public string ShowHiddenRule { get; set; }
}
