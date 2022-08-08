using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings.Columns
{
    [ColumnsScript("GeneralSettings.District")]
    [BasedOnRow(typeof(DistrictRow), CheckNames = true)]
    public class DistrictColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int DistrictId { get; set; }
        [EditLink]
        public string DistrictName { get; set; }
        public string CityCityName { get; set; }
    }
}