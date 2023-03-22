using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseGroup
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int GroupId { get; set; }

    public int IndexDictId { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public decimal? NumericValue { get; set; }

    public DateTime? DateTimeValue { get; set; }

    public string Source { get; set; }
}
