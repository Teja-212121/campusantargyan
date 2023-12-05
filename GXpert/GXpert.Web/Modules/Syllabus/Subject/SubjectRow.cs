﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("Subjects")]
[DisplayName("Subject"), InstanceName("Subject"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class SubjectRow : Row<SubjectRow.RowFields>, IIdRow, INameRow
{
    const string jClass = nameof(jClass);
    const string jMedium = nameof(jMedium);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public short? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Medium"), NotNull, ForeignKey("Mediums", "Id"), LeftJoin(jMedium), TextualField(nameof(MediumTitle))]
    public int? MediumId { get => fields.MediumId[this]; set => fields.MediumId[this] = value; }

    [DisplayName("Weightage")]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

    [DisplayName("Thumbnail"), Size(500)]
    public string Thumbnail { get => fields.Thumbnail[this]; set => fields.Thumbnail[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date")]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id")]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Medium Title"), Expression($"{jMedium}.[Title]")]
    public string MediumTitle { get => fields.MediumTitle[this]; set => fields.MediumTitle[this] = value; }
}