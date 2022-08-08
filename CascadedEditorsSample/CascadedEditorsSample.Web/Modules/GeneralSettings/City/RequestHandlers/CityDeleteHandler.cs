using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CascadedEditorsSample.GeneralSettings.CityRow;

namespace CascadedEditorsSample.GeneralSettings
{
    public interface ICityDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CityDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICityDeleteHandler
    {
        public CityDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}