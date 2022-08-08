using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CascadedEditorsSample.GeneralSettings.DistrictRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.DistrictRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface IDistrictRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class DistrictRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictRetrieveHandler
    {
        public DistrictRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}