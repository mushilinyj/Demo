using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectOutinQuery
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int ProjectId { get; set; }

    public int AddUserId { get; set; }

    public int Status { get; set; }

    public string Describe { get; set; }

    public DateTime? AddTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int Type { get; set; }

    public int UpdateUserId { get; set; }

    public string IndexDictId { get; set; }

    public int? SourceProjectId { get; set; }

    public string Query { get; set; }

    public string Title { get; set; }

    public string Querybson { get; set; }

    public int? Sort { get; set; }
}
