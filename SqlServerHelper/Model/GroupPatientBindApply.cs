using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class GroupPatientBindApply
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string OpenId { get; set; }

    public string UnionId { get; set; }

    public string Name { get; set; }

    public string PhoneNumber { get; set; }

    public string CardId { get; set; }

    public string Reason { get; set; }

    public string InpNo { get; set; }

    public byte? Status { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? ApprovalTime { get; set; }
}
