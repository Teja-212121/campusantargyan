﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("Contents")]
[DisplayName("Content"), InstanceName("Content"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class ContentRow : Row<ContentRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(500)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("E Content Type"), NotNull]
    public short? EContentType { get => fields.EContentType[this]; set => fields.EContentType[this] = value; }

    [DisplayName("File Key Url"), Column("FileKeyURL"), NotNull]
    public string FileKeyUrl { get => fields.FileKeyUrl[this]; set => fields.FileKeyUrl[this] = value; }

    [DisplayName("Iv"), Column("IV"), Size(2000), NotNull]
    public string Iv { get => fields.Iv[this]; set => fields.Iv[this] = value; }

    [DisplayName("File Path"), NotNull]
    public string FilePath { get => fields.FilePath[this]; set => fields.FilePath[this] = value; }

    [DisplayName("File Path Fall Back1"), NotNull]
    public string FilePathFallBack1 { get => fields.FilePathFallBack1[this]; set => fields.FilePathFallBack1[this] = value; }

    [DisplayName("File Path Fall Back2"), NotNull]
    public string FilePathFallBack2 { get => fields.FilePathFallBack2[this]; set => fields.FilePathFallBack2[this] = value; }

    [DisplayName("Media Info"), NotNull]
    public string MediaInfo { get => fields.MediaInfo[this]; set => fields.MediaInfo[this] = value; }

    [DisplayName("Thumb Nail"), NotNull]
    public string ThumbNail { get => fields.ThumbNail[this]; set => fields.ThumbNail[this] = value; }

    [DisplayName("Poster"), Size(200), NotNull]
    public string Poster { get => fields.Poster[this]; set => fields.Poster[this] = value; }

    [DisplayName("Length"), NotNull]
    public int? Length { get => fields.Length[this]; set => fields.Length[this] = value; }

    [DisplayName("Size"), NotNull]
    public int? Size { get => fields.Size[this]; set => fields.Size[this] = value; }

    [DisplayName("Number Of Pages"), NotNull]
    public int? NumberOfPages { get => fields.NumberOfPages[this]; set => fields.NumberOfPages[this] = value; }

    [DisplayName("Likes Count"), NotNull]
    public int? LikesCount { get => fields.LikesCount[this]; set => fields.LikesCount[this] = value; }

    [DisplayName("Dis Likes Count"), NotNull]
    public int? DisLikesCount { get => fields.DisLikesCount[this]; set => fields.DisLikesCount[this] = value; }

    [DisplayName("Hand Raise Count"), NotNull]
    public int? HandRaiseCount { get => fields.HandRaiseCount[this]; set => fields.HandRaiseCount[this] = value; }

    [DisplayName("Search Tags"), Size(500), NotNull]
    public string SearchTags { get => fields.SearchTags[this]; set => fields.SearchTags[this] = value; }

    [DisplayName("E Difficulty Level"), Column("eDifficultyLevel"), NotNull]
    public short? EDifficultyLevel { get => fields.EDifficultyLevel[this]; set => fields.EDifficultyLevel[this] = value; }

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
}