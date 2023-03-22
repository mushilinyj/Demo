using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Index
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? CateId { get; set; }

    public string IndexType { get; set; }

    public string EnumValues { get; set; }
}
