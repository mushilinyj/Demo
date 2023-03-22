using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class IndexCollectorIndexDict
{
    public int Id { get; set; }

    public int IndexCollectorId { get; set; }

    public int IndexDictId { get; set; }

    public int Sort { get; set; }
}
