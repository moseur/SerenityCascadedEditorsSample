using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<CascadedEditorsSample.GeneralSettings.CountryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CascadedEditorsSample.GeneralSettings.CountryRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICountrySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CountrySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICountrySaveHandler
    {
        public CountrySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}