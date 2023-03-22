using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class GroupPatientBindInfoBak
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int MedCaseId { get; set; }

    public string InpNo { get; set; }

    public string OpenId { get; set; }

    public string UnionId { get; set; }

    public string InterviewName { get; set; }

    public string InterviewPhoneNumber { get; set; }

    public DateTime? AddTime { get; set; }
}
