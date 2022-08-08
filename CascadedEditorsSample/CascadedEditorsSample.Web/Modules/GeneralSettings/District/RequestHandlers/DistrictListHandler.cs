using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CascadedEditorsSample.GeneralSettings.DistrictRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.DistrictRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface IDistrictListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class DistrictListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictListHandler
    {
        public DistrictListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}