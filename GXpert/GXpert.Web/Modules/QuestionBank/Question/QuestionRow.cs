﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank;

[ConnectionKey("Default"), Module("QuestionBank"), TableName("Questions")]
[DisplayName("Question"), InstanceName("Question"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class QuestionRow : Row<QuestionRow.RowFields>, IIdRow, INameRow
{
    const string jQuestionCommonData = nameof(jQuestionCommonData);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);
    const string jBloomsIndex = nameof(jBloomsIndex);

    [DisplayName("Id"), Identity, IdProperty]
    public long? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question Text"), NotNull, QuickSearch, NameProperty]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }

    [DisplayName("Explaination")]
    public string Explaination { get => fields.Explaination[this]; set => fields.Explaination[this] = value; }

    [DisplayName("Is Subjective"), NotNull]
    public bool? IsSubjective { get => fields.IsSubjective[this]; set => fields.IsSubjective[this] = value; }

    [DisplayName("E Question Type"), NotNull]
    public short? EQuestionType { get => fields.EQuestionType[this]; set => fields.EQuestionType[this] = value; }

    [DisplayName("E Difficulty Level"), NotNull]
    public short? EDifficultyLevel { get => fields.EDifficultyLevel[this]; set => fields.EDifficultyLevel[this] = value; }

    [DisplayName("Question Common Data"), ForeignKey(typeof(CommonDataRow)), LeftJoin(jQuestionCommonData)]
    [TextualField(nameof(QuestionCommonDataCommonDataTitle)), ServiceLookupEditor(typeof(CommonDataRow))]
    public int? QuestionCommonDataId { get => fields.QuestionCommonDataId[this]; set => fields.QuestionCommonDataId[this] = value; }

    [DisplayName("Question Common Data Sort Order")]
    public float? QuestionCommonDataSortOrder { get => fields.QuestionCommonDataSortOrder[this]; set => fields.QuestionCommonDataSortOrder[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Blooms Index"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsIndex)]
    [TextualField(nameof(BloomsIndexCoginitiveSkill))]
    public int? BloomsIndex { get => fields.BloomsIndex[this]; set => fields.BloomsIndex[this] = value; }

    [DisplayName("Blooms Weightage")]
    public float? BloomsWeightage { get => fields.BloomsWeightage[this]; set => fields.BloomsWeightage[this] = value; }

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

    [DisplayName("Question Common Data Common Data Title"), Origin(jQuestionCommonData, nameof(CommonDataRow.CommonDataTitle))]
    public string QuestionCommonDataCommonDataTitle { get => fields.QuestionCommonDataCommonDataTitle[this]; set => fields.QuestionCommonDataCommonDataTitle[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }

    [DisplayName("Blooms Index Coginitive Skill"), Expression($"{jBloomsIndex}.[CoginitiveSkill]")]
    public string BloomsIndexCoginitiveSkill { get => fields.BloomsIndexCoginitiveSkill[this]; set => fields.BloomsIndexCoginitiveSkill[this] = value; }
}