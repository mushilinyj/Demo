using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ServicePeriod
{
    public int Id { get; set; }

    public string Machine { get; set; }

    public string Name { get; set; }

    public DateTime? ServiceStartDate { get; set; }

    public DateTime? ServiceEndDate { get; set; }
}
