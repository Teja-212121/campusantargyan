﻿import { IntegerEditor, ServiceLookupEditor, StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ActivationForm {
    PlayListId: IntegerEditor;
    TeacherId: IntegerEditor;
    ActivationLogId: ServiceLookupEditor;
    DeviceId: StringEditor;
    DeviceDetails: StringEditor;
    ActivationDate: DateEditor;
    ExpiryDate: DateEditor;
    EStatus: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class ActivationForm extends PrefixedContext {
    static readonly formKey = 'Activation.Activation';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ActivationForm.init)  {
            ActivationForm.init = true;

            var w0 = IntegerEditor;
            var w1 = ServiceLookupEditor;
            var w2 = StringEditor;
            var w3 = DateEditor;

            initFormType(ActivationForm, [
                'PlayListId', w0,
                'TeacherId', w0,
                'ActivationLogId', w1,
                'DeviceId', w2,
                'DeviceDetails', w2,
                'ActivationDate', w3,
                'ExpiryDate', w3,
                'EStatus', w0,
                'InsertDate', w3,
                'InsertUserId', w0,
                'UpdateDate', w3,
                'UpdateUserId', w0,
                'IsActive', w0
            ]);
        }
    }
}