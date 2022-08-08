using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CascadedEditorsSample.GeneralSettings.CityRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.CityRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICityListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CityListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICityListHandler
    {
        public CityListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}