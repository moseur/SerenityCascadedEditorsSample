using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace CascadedEditorsSample.GeneralSettings.Forms
{
    [FormScript("GeneralSettings.Country")]
    [BasedOnRow(typeof(CountryRow), CheckNames = true)]
    public class CountryForm
    {
        public string CountryName { get; set; }
        public string Description { get; set; }
    }
}