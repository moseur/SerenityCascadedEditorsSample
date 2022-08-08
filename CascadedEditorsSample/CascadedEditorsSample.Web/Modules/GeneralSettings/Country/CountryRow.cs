using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings
{
    [ConnectionKey("Default"), Module("GeneralSettings"), TableName("[gen].[Country]")]
    [DisplayName("Country"), InstanceName("Country")]
    [ReadPermission("GeneralSettings:Country:View")]
    [InsertPermission("GeneralSettings:Country:Insert")]
    [UpdatePermission("GeneralSettings:Country:Update")]
    [DeletePermission("GeneralSettings:Country:Delete")]
    [LookupScript("GeneralSettings.Country")]
    public sealed class CountryRow : Row<CountryRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Country Id"), Identity, IdProperty]
        public int? CountryId
        {
            get => fields.CountryId[this];
            set => fields.CountryId[this] = value;
        }

        [DisplayName("Country Name"), Size(200), NotNull, QuickSearch, NameProperty]
        public string CountryName
        {
            get => fields.CountryName[this];
            set => fields.CountryName[this] = value;
        }

        [DisplayName("Description"), Size(1000)]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        public CountryRow()
            : base()
        {
        }

        public CountryRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field CountryId;
            public StringField CountryName;
            public StringField Description;
        }
    }
}
