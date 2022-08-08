using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CascadedEditorsSample.GeneralSettings.CustomerRow>;
using MyRow = CascadedEditorsSample.GeneralSettings.CustomerRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICustomerListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerListHandler
    {
        public CustomerListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}