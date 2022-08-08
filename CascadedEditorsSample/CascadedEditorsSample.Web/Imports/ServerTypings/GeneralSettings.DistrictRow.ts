namespace CascadedEditorsSample.GeneralSettings {
    export interface DistrictRow {
        DistrictId?: number;
        DistrictName?: string;
        CityId?: number;
        CityCityName?: string;
        CityCountryId?: number;
    }

    export namespace DistrictRow {
        export const idProperty = 'DistrictId';
        export const nameProperty = 'DistrictName';
        export const localTextPrefix = 'GeneralSettings.District';
        export const lookupKey = 'GeneralSettings.District';

        export function getLookup(): Q.Lookup<DistrictRow> {
            return Q.getLookup<DistrictRow>('GeneralSettings.District');
        }
        export const deletePermission = 'GeneralSettings:District:Delete';
        export const insertPermission = 'GeneralSettings:District:Insert';
        export const readPermission = 'GeneralSettings:District:View';
        export const updatePermission = 'GeneralSettings:District:Update';

        export declare const enum Fields {
            DistrictId = "DistrictId",
            DistrictName = "DistrictName",
            CityId = "CityId",
            CityCityName = "CityCityName",
            CityCountryId = "CityCountryId"
        }
    }
}
