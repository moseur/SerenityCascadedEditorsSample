using Serenity.Navigation;
using MyPages = CascadedEditorsSample.GeneralSettings.Pages;

[assembly: NavigationMenu(2000, "GeneralSettings", icon: "fa-wrench")]
[assembly: NavigationLink(2001, "GeneralSettings/Country", typeof(MyPages.CountryController), icon: null)]
[assembly: NavigationLink(2002, "GeneralSettings/City", typeof(MyPages.CityController), icon: null)]
[assembly: NavigationLink(2003, "GeneralSettings/District", typeof(MyPages.DistrictController), icon: null)]
[assembly: NavigationLink(2004, "GeneralSettings/Customer", typeof(MyPages.CustomerController), icon: null)]