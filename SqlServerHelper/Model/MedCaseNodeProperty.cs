using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseNodeProperty
{
    public long Id { get; set; }

    public int MedCaseNodeId { get; set; }

    public int MedCaseRootNodeId { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public string NumericName { get; set; }

    public string NumericUnit { get; set; }

    public decimal? NumericValue { get; set; }

    public DateTime? DateTimeValue { get; set; }

    public byte? Tips { get; set; }

    public int IndexDictId { get; set; }
}
