using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseAnswerRecord
{
    public int Id { get; set; }

    public int MedCaseId { get; set; }

    public string RobotId { get; set; }

    public string UnionId { get; set; }

    public byte Unanswered { get; set; }
}
