﻿using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Exams.ExamSectionRow;

namespace GXpert.Exams;

public interface IExamSectionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ExamSectionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamSectionDeleteHandler
{
    public ExamSectionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}