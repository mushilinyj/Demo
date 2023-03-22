using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectTabQuery
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    public int SourceProjectId { get; set; }

    public int HistoryCase { get; set; }

    public string Title { get; set; }

    public string Bson { get; set; }

    public int AddUserId { get; set; }

    public DateTime AddTime { get; set; }

    public string RowIndex { get; set; }

    public string RowName { get; set; }

    public string OrderKey { get; set; }

    public string OrderMethod { get; set; }

    public string OrderName { get; set; }
}
