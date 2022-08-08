using FluentMigrator;

namespace CascadedEditorsSample.Migrations.DefaultDB
{
	[Migration(20220807130002)]
	public class DefaultDB_20220807_130002_Alltables : Migration
	{
        public override void Up()
        {

            Create.Table("Customer").InSchema("gen")
                .WithColumn("CustomerId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("CustomerName").AsString(200).NotNullable()
                .WithColumn("CountryId").AsInt32().Nullable()
                    .ForeignKey("FK_Customer_CountryId", "gen", "Country", "CountryId")
                .WithColumn("CityId").AsInt32().Nullable()
                    .ForeignKey("FK_Customer_CityId", "gen", "City", "CityId")
                .WithColumn("DistrictId").AsInt32().Nullable()
                    .ForeignKey("FK_Customer_DistrictId", "gen", "District", "DistrictId");

        }

        public override void Down()
        {
        }
    }
}
