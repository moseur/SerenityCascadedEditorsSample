using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<CascadedEditorsSample.GeneralSettings.DistrictRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CascadedEditorsSample.GeneralSettings.DistrictRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface IDistrictSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class DistrictSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictSaveHandler
    {
        public DistrictSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}