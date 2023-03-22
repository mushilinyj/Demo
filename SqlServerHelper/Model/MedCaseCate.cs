using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseCate
{
    public int Id { get; set; }

    public string Key { get; set; }

    public string Name { get; set; }

    public int? Weight { get; set; }
}
