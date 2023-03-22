using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class FileUploadLogger
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int UserId { get; set; }

    public string FileName { get; set; }

    public string DataHash { get; set; }

    public DateTime UploadTime { get; set; }
}
