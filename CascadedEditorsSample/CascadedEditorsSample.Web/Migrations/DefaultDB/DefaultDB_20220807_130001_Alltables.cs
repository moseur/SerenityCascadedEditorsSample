using FluentMigrator;

namespace CascadedEditorsSample.Migrations.DefaultDB
{
	[Migration(20220807_130001)]
	public class DefaultDB_20220807_130001_Alltables : Migration
	{
        public override void Up()
        {
            Create.Schema("gen");

            Create.Table("Country").InSchema("gen")
                .WithColumn("CountryId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("CountryName").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable();

            Create.Table("City").InSchema("gen")
                .WithColumn("CityId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("CityName").AsString(200).NotNullable()
                .WithColumn("CountryId").AsInt32().Nullable()
                    .ForeignKey("FK_City_CountryId", "gen", "Country", "CountryId");

            Create.Table("District").InSchema("gen")
                .WithColumn("DistrictId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("DistrictName").AsString(200).NotNullable()
                .WithColumn("CityId").AsInt32().Nullable()
                    .ForeignKey("FK_District_CityId", "gen", "City", "CityId");
        }

        public override void Down()
        {
        }
    }
}
