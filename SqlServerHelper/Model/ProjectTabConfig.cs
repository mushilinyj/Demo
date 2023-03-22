using System;
using System.Collections.Generic;

namespace SqlServerHelper.Model;

public partial class ProjectTabConfig
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public int ProjectTabId { get; set; }

    public int HtmlControlId { get; set; }

    public int? ProjectIndexDictId { get; set; }

    public string ValidationRuleType { get; set; }

    public string MultilineRows { get; set; }

    public string MaxLength { get; set; }

    public string NumberMin { get; set; }

    public string NumberMax { get; set; }

    public string Decimal { get; set; }

    public string DivWidth { get; set; }

    public string ShowType { get; set; }

    public string IsRequired { get; set; }

    public string ShowTableHeader { get; set; }

    public string ShowUpload { get; set; }

    public string ShowDownloadTemp { get; set; }

    public string FileViaTabId { get; set; }

    public string ShowCreatePdf { get; set; }

    public string ButtonName { get; set; }

    public string DateFormat { get; set; }

    public string IndexDictType { get; set; }

    public string Remark { get; set; }
}
