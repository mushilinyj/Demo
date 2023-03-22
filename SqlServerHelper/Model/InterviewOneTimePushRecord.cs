using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class InterviewOneTimePushRecord
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public string OpenIds { get; set; }

    public string Title { get; set; }

    public string Remark { get; set; }

    public string Content { get; set; }

    public string Result { get; set; }

    public int? SendUserId { get; set; }

    public DateTime? SendTime { get; set; }
}
