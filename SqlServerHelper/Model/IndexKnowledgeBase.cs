using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class IndexKnowledgeBase
{
    public int Id { get; set; }

    public string Regex { get; set; }

    public string StatType { get; set; }

    public string Unit { get; set; }

    public decimal? Min { get; set; }

    public decimal? Max { get; set; }
}
