using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<CascadedEditorsSample.GeneralSettings.CityRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CascadedEditorsSample.GeneralSettings.CityRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICitySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CitySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICitySaveHandler
    {
        public CitySaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}