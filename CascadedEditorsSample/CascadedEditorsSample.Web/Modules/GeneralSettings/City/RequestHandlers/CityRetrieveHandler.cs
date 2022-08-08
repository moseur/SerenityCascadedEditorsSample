using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CascadedEditorsSample.GeneralSettings.CityRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.CityRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICityRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CityRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICityRetrieveHandler
    {
        public CityRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}