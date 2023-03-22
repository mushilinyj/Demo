using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseCoreDatum
{
    public string DataHash { get; set; }

    public string CoreData { get; set; }

    public byte[] ImageBits { get; set; }

    public string ImageTitle { get; set; }

    public DateTime? ImageDate { get; set; }

    public DateTime AddTime { get; set; }
}
