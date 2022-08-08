using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using Serenity.Extensions;

namespace CascadedEditorsSample.GeneralSettings.Forms
{
    [FormScript("GeneralSettings.Customer")]
    [BasedOnRow(typeof(GeneralSettings.CustomerRow))]
    public class CustomerForm
    {
        public string CustomerName { get; set; }

        [LookupEditor(typeof(GeneralSettings.CountryRow))]
        public int CountryId { get; set; }

        [LookupEditor(typeof(GeneralSettings.CityRow),
        CascadeFrom = "CountryId", CascadeField = "CountryId")]
        public int CityId { get; set; }

        [LookupEditor(typeof(GeneralSettings.DistrictRow),
        CascadeFrom = "CityId", CascadeField = "CityId")]
        public int DistrictId { get; set; }
    }
}