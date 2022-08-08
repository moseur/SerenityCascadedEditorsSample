namespace CascadedEditorsSample.GeneralSettings {
    export interface CityRow {
        CityId?: number;
        CityName?: string;
        CountryId?: number;
        CountryCountryName?: string;
        CountryDescription?: string;
    }

    export namespace CityRow {
        export const idProperty = 'CityId';
        export const nameProperty = 'CityName';
        export const localTextPrefix = 'GeneralSettings.City';
        export const lookupKey = 'GeneralSettings.City';

        export function getLookup(): Q.Lookup<CityRow> {
            return Q.getLookup<CityRow>('GeneralSettings.City');
        }
        export const deletePermission = 'GeneralSettings:City:Delete';
        export const insertPermission = 'GeneralSettings:City:Insert';
        export const readPermission = 'GeneralSettings:City:View';
        export const updatePermission = 'GeneralSettings:City:Update';

        export declare const enum Fields {
            CityId = "CityId",
            CityName = "CityName",
            CountryId = "CountryId",
            CountryCountryName = "CountryCountryName",
            CountryDescription = "CountryDescription"
        }
    }
}
