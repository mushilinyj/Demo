using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class MedCaseMessage
{
    public int Id { get; set; }

    public string OpenId { get; set; }

    public int GroupId { get; set; }

    public string Message { get; set; }

    /// <summary>
    /// 消息类型，text/pict/file
    /// </summary>
    public string MessageType { get; set; }

    /// <summary>
    /// 0表示未回复，1表示已回复
    /// </summary>
    public int IsReply { get; set; }

    public int UserId { get; set; }

    public DateTime AddTime { get; set; }

    public int MedCaseId { get; set; }

    public int MessageId { get; set; }

    public int IsClick { get; set; }

    public string Remark { get; set; }
}
