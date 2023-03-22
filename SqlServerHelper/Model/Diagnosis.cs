using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Diagnosis
{
    public int Id { get; set; }

    public string Icd10Code { get; set; }

    public string Name { get; set; }
}
