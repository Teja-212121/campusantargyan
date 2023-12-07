﻿import { StringEditor, IntegerEditor, ServiceLookupEditor, DecimalEditor, DateEditor, BooleanEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface SubjectForm {
    Title: StringEditor;
    Description: StringEditor;
    SortOrder: IntegerEditor;
    ClassId: ServiceLookupEditor;
    MediumId: ServiceLookupEditor;
    Weightage: DecimalEditor;
    Thumbnail: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: BooleanEditor;
}

export class SubjectForm extends PrefixedContext {
    static readonly formKey = 'Syllabus.Subject';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubjectForm.init)  {
            SubjectForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;
            var w3 = DecimalEditor;
            var w4 = DateEditor;
            var w5 = BooleanEditor;

            initFormType(SubjectForm, [
                'Title', w0,
                'Description', w0,
                'SortOrder', w1,
                'ClassId', w2,
                'MediumId', w2,
                'Weightage', w3,
                'Thumbnail', w0,
                'InsertDate', w4,
                'InsertUserId', w1,
                'UpdateDate', w4,
                'UpdateUserId', w1,
                'IsActive', w5
            ]);
        }
    }
}