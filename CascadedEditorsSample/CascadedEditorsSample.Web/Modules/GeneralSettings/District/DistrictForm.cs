using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings.Forms
{
    [FormScript("GeneralSettings.District")]
    [BasedOnRow(typeof(DistrictRow), CheckNames = true)]
    public class DistrictForm
    {
        public string DistrictName { get; set; }
        public int CityId { get; set; }
    }
}