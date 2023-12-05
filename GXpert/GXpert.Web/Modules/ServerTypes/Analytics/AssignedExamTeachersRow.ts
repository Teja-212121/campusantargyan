﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface AssignedExamTeachersRow {
    Id?: number;
    ExamId?: number;
    PlayListId?: number;
    TeacherId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ExamTitle?: string;
    PlayListTitle?: string;
    TeacherPrn?: string;
}

export abstract class AssignedExamTeachersRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Analytics.AssignedExamTeachers';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AssignedExamTeachersRow>();
}