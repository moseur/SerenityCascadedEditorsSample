﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CascadedEditorsSample.GeneralSettings.CountryRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.CountryRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICountryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CountryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICountryListHandler
    {
        public CountryListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}