﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface QuestionOptionRow {
    Id?: number;
    QuestionId?: number;
    OptionText?: string;
    IsCorrect?: boolean;
    SortOrder?: number;
    Weightage?: number;
    IsActive?: boolean;
    QuestionText?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class QuestionOptionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'OptionText';
    static readonly localTextPrefix = 'QuestionBank.QuestionOption';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<QuestionOptionRow>();
}