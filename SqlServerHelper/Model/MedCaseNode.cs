using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseNode
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public int MedCaseParentNodeId { get; set; }

    public int MedCaseRootNodeId { get; set; }

    public string DisplayName { get; set; }

    public string Name { get; set; }

    public string Content { get; set; }

    public int? MedCaseCateId { get; set; }

    public byte? IsUnique { get; set; }

    public string DocNodeId { get; set; }

    public DateTime? NodeTime { get; set; }
}
