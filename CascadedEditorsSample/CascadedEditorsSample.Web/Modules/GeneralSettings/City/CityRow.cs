using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings
{
    [ConnectionKey("Default"), Module("GeneralSettings"), TableName("[gen].[City]")]
    [DisplayName("City"), InstanceName("City")]
    [ReadPermission("GeneralSettings:City:View")]
    [InsertPermission("GeneralSettings:City:Insert")]
    [UpdatePermission("GeneralSettings:City:Update")]
    [DeletePermission("GeneralSettings:City:Delete")]
    [LookupScript("GeneralSettings.City")]
    public sealed class CityRow : Row<CityRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("City Id"), Identity, IdProperty]
        public int? CityId
        {
            get => fields.CityId[this];
            set => fields.CityId[this] = value;
        }

        [DisplayName("City Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public string CityName
        {
            get => fields.CityName[this];
            set => fields.CityName[this] = value;
        }

        [DisplayName("Country"), ForeignKey("[gen].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryName"), LookupInclude]
        [LookupEditor(typeof(CountryRow))]
		public int? CountryId
        {
            get => fields.CountryId[this];
            set => fields.CountryId[this] = value;
        }

        [DisplayName("Country Country Name"), Expression("jCountry.[CountryName]")]
        public string CountryCountryName
        {
            get => fields.CountryCountryName[this];
            set => fields.CountryCountryName[this] = value;
        }

        [DisplayName("Country Description"), Expression("jCountry.[Description]")]
        public string CountryDescription
        {
            get => fields.CountryDescription[this];
            set => fields.CountryDescription[this] = value;
        }

        public CityRow()
            : base()
        {
        }

        public CityRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CityId;
            public StringField CityName;
            public Int32Field CountryId;

            public StringField CountryCountryName;
            public StringField CountryDescription;
        }
    }
}
