using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Statistic
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int ProjectId { get; set; }

    public int? StatisticsTypeId { get; set; }

    public string StatisticsParams { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? LastUpdateTime { get; set; }
}
