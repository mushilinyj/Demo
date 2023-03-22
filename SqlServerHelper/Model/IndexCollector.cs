using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class IndexCollector
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string Name { get; set; }

    public int Sort { get; set; }
}
