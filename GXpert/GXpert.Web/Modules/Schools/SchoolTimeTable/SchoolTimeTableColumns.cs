﻿using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Schools.Columns;

[ColumnsScript("Schools.SchoolTimeTable")]
[BasedOnRow(typeof(SchoolTimeTableRow), CheckNames = true)]
public class SchoolTimeTableColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int PeriodIndex { get; set; }
    public string SchoolClassDivision { get; set; }
    public string TeacherPrn { get; set; }
    [EditLink]
    public string EType { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}