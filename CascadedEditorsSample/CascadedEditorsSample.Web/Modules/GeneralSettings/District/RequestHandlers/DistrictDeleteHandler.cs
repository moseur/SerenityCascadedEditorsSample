using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CascadedEditorsSample.GeneralSettings.DistrictRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface IDistrictDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class DistrictDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictDeleteHandler
    {
        public DistrictDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}