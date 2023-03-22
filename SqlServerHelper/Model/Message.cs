using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class Message
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; }

    public byte? Type { get; set; }

    public int? GroupUserId { get; set; }

    public int? GroupUserApplyId { get; set; }

    public int? GroupPatientBindApplyId { get; set; }

    public byte Status { get; set; }

    public DateTime? AddTime { get; set; }

    public int? PatientFollowUpRemindId { get; set; }

    public string ChangContent { get; set; }
}
