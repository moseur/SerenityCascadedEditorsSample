using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings.Columns
{
    [ColumnsScript("GeneralSettings.Customer")]
    [BasedOnRow(typeof(CustomerRow), CheckNames = true)]
    public class CustomerColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int CustomerId { get; set; }
        [EditLink]
        public string CustomerName { get; set; }
        public string CountryCountryName { get; set; }
        public string CityCityName { get; set; }
        public string DistrictDistrictName { get; set; }
    }
}