using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class StatisticsType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string StatisticsFormula { get; set; }

    public string StatisticsParamKeys { get; set; }
}
