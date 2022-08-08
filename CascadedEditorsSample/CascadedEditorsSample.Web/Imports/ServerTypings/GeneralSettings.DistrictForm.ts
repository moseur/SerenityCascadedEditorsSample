namespace CascadedEditorsSample.GeneralSettings {
    export interface DistrictForm {
        DistrictName: Serenity.StringEditor;
        CityId: Serenity.LookupEditor;
    }

    export class DistrictForm extends Serenity.PrefixedContext {
        static formKey = 'GeneralSettings.District';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DistrictForm.init)  {
                DistrictForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(DistrictForm, [
                    'DistrictName', w0,
                    'CityId', w1
                ]);
            }
        }
    }
}
