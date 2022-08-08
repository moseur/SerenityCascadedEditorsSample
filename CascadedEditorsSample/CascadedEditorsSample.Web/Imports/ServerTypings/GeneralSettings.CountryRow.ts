namespace CascadedEditorsSample.GeneralSettings {
    export interface CountryRow {
        CountryId?: number;
        CountryName?: string;
        Description?: string;
    }

    export namespace CountryRow {
        export const idProperty = 'CountryId';
        export const nameProperty = 'CountryName';
        export const localTextPrefix = 'GeneralSettings.Country';
        export const lookupKey = 'GeneralSettings.Country';

        export function getLookup(): Q.Lookup<CountryRow> {
            return Q.getLookup<CountryRow>('GeneralSettings.Country');
        }
        export const deletePermission = 'GeneralSettings:Country:Delete';
        export const insertPermission = 'GeneralSettings:Country:Insert';
        export const readPermission = 'GeneralSettings:Country:View';
        export const updatePermission = 'GeneralSettings:Country:Update';

        export declare const enum Fields {
            CountryId = "CountryId",
            CountryName = "CountryName",
            Description = "Description"
        }
    }
}
