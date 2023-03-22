using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class InterviewCalendar
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    public int InterviewId { get; set; }

    public DateTime InterviewDate { get; set; }

    /// <summary>
    /// 0是患者1是医生
    /// </summary>
    public byte InterviewWho { get; set; }

    public int Sent { get; set; }

    public int WaitingToSend { get; set; }

    public int SentNoReply { get; set; }

    public int SentAndReply { get; set; }
}
