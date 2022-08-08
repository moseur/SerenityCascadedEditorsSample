namespace CascadedEditorsSample.GeneralSettings {
    export interface CityForm {
        CityName: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
    }

    export class CityForm extends Serenity.PrefixedContext {
        static formKey = 'GeneralSettings.City';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CityForm.init)  {
                CityForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(CityForm, [
                    'CityName', w0,
                    'CountryId', w1
                ]);
            }
        }
    }
}
