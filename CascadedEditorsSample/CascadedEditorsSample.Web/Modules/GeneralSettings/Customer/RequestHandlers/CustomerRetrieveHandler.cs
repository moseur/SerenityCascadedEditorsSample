using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CascadedEditorsSample.GeneralSettings.CustomerRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.CustomerRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICustomerRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerRetrieveHandler
    {
        public CustomerRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}