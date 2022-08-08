namespace CascadedEditorsSample.GeneralSettings {
    export interface CustomerRow {
        CustomerId?: number;
        CustomerName?: string;
        CountryId?: number;
        CityId?: number;
        DistrictId?: number;
        CountryCountryName?: string;
        CountryDescription?: string;
        CityCityName?: string;
        CityCountryId?: number;
        DistrictDistrictName?: string;
        DistrictCityId?: number;
    }

    export namespace CustomerRow {
        export const idProperty = 'CustomerId';
        export const nameProperty = 'CustomerName';
        export const localTextPrefix = 'GeneralSettings.Customer';
        export const deletePermission = 'GeneralSettings:Customer:Delete';
        export const insertPermission = 'GeneralSettings:Customer:Insert';
        export const readPermission = 'GeneralSettings:Customer:View';
        export const updatePermission = 'GeneralSettings:Customer:Update';

        export declare const enum Fields {
            CustomerId = "CustomerId",
            CustomerName = "CustomerName",
            CountryId = "CountryId",
            CityId = "CityId",
            DistrictId = "DistrictId",
            CountryCountryName = "CountryCountryName",
            CountryDescription = "CountryDescription",
            CityCityName = "CityCityName",
            CityCountryId = "CityCountryId",
            DistrictDistrictName = "DistrictDistrictName",
            DistrictCityId = "DistrictCityId"
        }
    }
}
