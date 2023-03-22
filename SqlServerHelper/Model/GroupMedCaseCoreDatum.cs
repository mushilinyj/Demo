using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class GroupMedCaseCoreDatum
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int MedCaseId { get; set; }

    public string DataHash { get; set; }

    public byte Refreshed { get; set; }

    public byte[] ImageBits { get; set; }

    public string ImageTitle { get; set; }

    public DateTime? ImageDate { get; set; }

    public DateTime AddTime { get; set; }
}
