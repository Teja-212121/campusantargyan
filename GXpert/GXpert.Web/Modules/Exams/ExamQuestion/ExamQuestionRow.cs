﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GXpert.Exams;

[ConnectionKey("Default"), Module("Exams"), TableName("ExamQuestions")]
[DisplayName("Exam Question"), InstanceName("Exam Question"), GenerateFields]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed partial class ExamQuestionRow : Row<ExamQuestionRow.RowFields>, IIdRow, INameRow
{
    const string jExam = nameof(jExam);
    const string jExamSection = nameof(jExamSection);
    const string jQuestion = nameof(jQuestion);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Exam"), NotNull, ForeignKey(typeof(ExamRow)), LeftJoin(jExam), TextualField(nameof(ExamTitle))]
    [ServiceLookupEditor(typeof(ExamRow))]
    public int? ExamId { get => fields.ExamId[this]; set => fields.ExamId[this] = value; }

    [DisplayName("Exam Section"), ForeignKey(typeof(ExamSectionRow)), LeftJoin(jExamSection), TextualField(nameof(ExamSectionTitle))]
    [ServiceLookupEditor(typeof(ExamSectionRow))]
    public int? ExamSectionId { get => fields.ExamSectionId[this]; set => fields.ExamSectionId[this] = value; }

    [DisplayName("Question"), NotNull, ForeignKey("Questions", "Id"), LeftJoin(jQuestion), TextualField(nameof(QuestionText))]
    public long? QuestionId { get => fields.QuestionId[this]; set => fields.QuestionId[this] = value; }

    [DisplayName("E Difficulty Level"), NotNull]
    public short? EDifficultyLevel { get => fields.EDifficultyLevel[this]; set => fields.EDifficultyLevel[this] = value; }

    [DisplayName("Right Answer"), Size(500), QuickSearch, NameProperty]
    public string RightAnswer { get => fields.RightAnswer[this]; set => fields.RightAnswer[this] = value; }

    [DisplayName("Marks"), NotNull]
    public float? Marks { get => fields.Marks[this]; set => fields.Marks[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public float? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), NotNull, ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Insert Date"), NotNull]
    public DateTime? InsertDate { get => fields.InsertDate[this]; set => fields.InsertDate[this] = value; }

    [DisplayName("Insert User Id"), NotNull]
    public int? InsertUserId { get => fields.InsertUserId[this]; set => fields.InsertUserId[this] = value; }

    [DisplayName("Update Date"), NotNull]
    public DateTime? UpdateDate { get => fields.UpdateDate[this]; set => fields.UpdateDate[this] = value; }

    [DisplayName("Update User Id"), NotNull]
    public int? UpdateUserId { get => fields.UpdateUserId[this]; set => fields.UpdateUserId[this] = value; }

    [DisplayName("Is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Exam Title"), Origin(jExam, nameof(ExamRow.Title))]
    public string ExamTitle { get => fields.ExamTitle[this]; set => fields.ExamTitle[this] = value; }

    [DisplayName("Exam Section Title"), Origin(jExamSection, nameof(ExamSectionRow.Title))]
    public string ExamSectionTitle { get => fields.ExamSectionTitle[this]; set => fields.ExamSectionTitle[this] = value; }

    [DisplayName("Question Question Text"), Expression($"{jQuestion}.[QuestionText]")]
    public string QuestionText { get => fields.QuestionText[this]; set => fields.QuestionText[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }
}