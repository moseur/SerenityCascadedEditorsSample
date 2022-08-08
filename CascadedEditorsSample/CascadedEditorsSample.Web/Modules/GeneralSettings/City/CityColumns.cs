using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings.Columns
{
    [ColumnsScript("GeneralSettings.City")]
    [BasedOnRow(typeof(CityRow), CheckNames = true)]
    public class CityColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int CityId { get; set; }
        [EditLink]
        public string CityName { get; set; }
        public string CountryCountryName { get; set; }
    }
}