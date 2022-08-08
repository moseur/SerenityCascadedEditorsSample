using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings
{
    [ConnectionKey("Default"), Module("GeneralSettings"), TableName("[gen].[Customer]")]
    [DisplayName("Customer"), InstanceName("Customer")]
    [ReadPermission("GeneralSettings:Customer:View")]
    [InsertPermission("GeneralSettings:Customer:Insert")]
    [UpdatePermission("GeneralSettings:Customer:Update")]
    [DeletePermission("GeneralSettings:Customer:Delete")]

    public sealed class CustomerRow : Row<CustomerRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Customer Id"), Identity, IdProperty]
        public int? CustomerId
        {
            get => fields.CustomerId[this];
            set => fields.CustomerId[this] = value;
        }

        [DisplayName("Customer Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public string CustomerName
        {
            get => fields.CustomerName[this];
            set => fields.CustomerName[this] = value;
        }

        [DisplayName("Country"), ForeignKey("[gen].[Country]", "CountryId"), LeftJoin("jCountry"), TextualField("CountryCountryName")]
        [LookupEditor(typeof(CountryRow))]
        public int? CountryId
        {
            get => fields.CountryId[this];
            set => fields.CountryId[this] = value;
        }

        [DisplayName("City"), ForeignKey("[gen].[City]", "CityId"), LeftJoin("jCity"), TextualField("CityCityName")]
        [LookupEditor(typeof(CityRow))]
        public int? CityId
        {
            get => fields.CityId[this];
            set => fields.CityId[this] = value;
        }

        [DisplayName("District"), ForeignKey("[gen].[District]", "DistrictId"), LeftJoin("jDistrict"), TextualField("DistrictDistrictName")]
        [LookupEditor(typeof(DistrictRow))]
        public int? DistrictId
        {
            get => fields.DistrictId[this];
            set => fields.DistrictId[this] = value;
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

        [DisplayName("City City Name"), Expression("jCity.[CityName]")]
        public string CityCityName
        {
            get => fields.CityCityName[this];
            set => fields.CityCityName[this] = value;
        }

        [DisplayName("City Country Id"), Expression("jCity.[CountryId]")]
        public int? CityCountryId
        {
            get => fields.CityCountryId[this];
            set => fields.CityCountryId[this] = value;
        }

        [DisplayName("District District Name"), Expression("jDistrict.[DistrictName]")]
        public string DistrictDistrictName
        {
            get => fields.DistrictDistrictName[this];
            set => fields.DistrictDistrictName[this] = value;
        }

        [DisplayName("District City Id"), Expression("jDistrict.[CityId]")]
        public int? DistrictCityId
        {
            get => fields.DistrictCityId[this];
            set => fields.DistrictCityId[this] = value;
        }

        public CustomerRow()
            : base()
        {
        }

        public CustomerRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CustomerId;
            public StringField CustomerName;
            public Int32Field CountryId;
            public Int32Field CityId;
            public Int32Field DistrictId;

            public StringField CountryCountryName;
            public StringField CountryDescription;

            public StringField CityCityName;
            public Int32Field CityCountryId;

            public StringField DistrictDistrictName;
            public Int32Field DistrictCityId;
        }
    }
}
