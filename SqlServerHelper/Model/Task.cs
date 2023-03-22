using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Task
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    public int IndexId { get; set; }

    public int GroupRoleId { get; set; }

    public string Title { get; set; }

    public int? ExecutionTimes { get; set; }

    public string ExecutionCycle { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? LastUpdateTime { get; set; }
}
