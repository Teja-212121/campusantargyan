﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface ExamAttemptQuestionRow {
    Id?: number;
    ExamAttemptId?: number;
    ExamQuestionId?: number;
    OptionSelected?: string;
    MarksObtained?: number;
    Attemptstatus?: number;
    OutOfmarks?: number;
    Result?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ExamAttemptStudentAnswerSheetUpload?: string;
    ExamQuestionRightAnswer?: string;
}

export abstract class ExamAttemptQuestionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'OptionSelected';
    static readonly localTextPrefix = 'Analytics.ExamAttemptQuestion';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamAttemptQuestionRow>();
}