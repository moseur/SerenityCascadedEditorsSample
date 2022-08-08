using Serenity.Services;

namespace CascadedEditorsSample.Administration
{
	public class UserRoleListRequest : ServiceRequest
	{
		public int? UserID { get; set; }
	}
}