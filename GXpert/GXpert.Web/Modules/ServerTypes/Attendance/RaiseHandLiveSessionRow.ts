﻿import { fieldsProxy } from "@serenity-is/corelib";
import { EHandRaiseStatus } from "../Web/Enums.EHandRaiseStatus";

export interface RaiseHandLiveSessionRow {
    Id?: number;
    LiveSessionlogId?: number;
    StudentId?: number;
    SessionTime?: string;
    HandRaiseStatus?: EHandRaiseStatus;
    PlayListId?: number;
    ActivationId?: number;
    IsActive?: boolean;
    StudentPrn?: string;
    PlayListTitle?: string;
    ActivationDeviceId?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class RaiseHandLiveSessionRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Attendance.RaiseHandLiveSession';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<RaiseHandLiveSessionRow>();
}