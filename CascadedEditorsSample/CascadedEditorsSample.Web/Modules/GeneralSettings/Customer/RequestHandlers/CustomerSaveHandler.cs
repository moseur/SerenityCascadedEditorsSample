using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<CascadedEditorsSample.GeneralSettings.CustomerRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CascadedEditorsSample.GeneralSettings.CustomerRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICustomerSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerSaveHandler
    {
        public CustomerSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}