using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class GroupUserApply
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int UserId { get; set; }

    public string Reason { get; set; }

    public byte? Status { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? ApprovalTime { get; set; }
}
