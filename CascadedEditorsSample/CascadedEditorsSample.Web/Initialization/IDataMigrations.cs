namespace CascadedEditorsSample
{
	public interface IDataMigrations
	{
		bool SkippedMigrations { get; }

		void Initialize();
	}
}