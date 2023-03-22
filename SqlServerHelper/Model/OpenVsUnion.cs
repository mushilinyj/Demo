using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class OpenVsUnion
{
    public int Id { get; set; }

    public string OpenId { get; set; }

    public string UnionId { get; set; }
}
