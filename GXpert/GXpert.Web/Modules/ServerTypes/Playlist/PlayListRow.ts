﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface PlayListRow {
    Id?: number;
    Title?: string;
    Description?: string;
    ClassId?: number;
    SubjectId?: number;
    TeacherId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: boolean;
    ClassTitle?: string;
    SubjectTitle?: string;
    TeacherPrn?: string;
}

export abstract class PlayListRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Playlist.PlayList';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PlayListRow>();
}