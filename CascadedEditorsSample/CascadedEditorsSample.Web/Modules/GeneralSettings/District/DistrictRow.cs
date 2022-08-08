using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings
{
    [ConnectionKey("Default"), Module("GeneralSettings"), TableName("[gen].[District]")]
    [DisplayName("District"), InstanceName("District")]
    [ReadPermission("GeneralSettings:District:View")]
    [InsertPermission("GeneralSettings:District:Insert")]
    [UpdatePermission("GeneralSettings:District:Update")]
    [DeletePermission("GeneralSettings:District:Delete")]
    [LookupScript("GeneralSettings.District")]
    public sealed class DistrictRow : Row<DistrictRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("District Id"), Identity, IdProperty]
        public int? DistrictId
        {
            get => fields.DistrictId[this];
            set => fields.DistrictId[this] = value;
        }

        [DisplayName("District Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public string DistrictName
        {
            get => fields.DistrictName[this];
            set => fields.DistrictName[this] = value;
        }

        [DisplayName("City"), ForeignKey("[gen].[City]", "CityId"), LeftJoin("jCity"), TextualField("CityCityName"), LookupInclude]
        [LookupEditor(typeof(CityRow))]
		public int? CityId
        {
            get => fields.CityId[this];
            set => fields.CityId[this] = value;
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

        public DistrictRow()
            : base()
        {
        }

        public DistrictRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field DistrictId;
            public StringField DistrictName;
            public Int32Field CityId;

            public StringField CityCityName;
            public Int32Field CityCountryId;
        }
    }
}
