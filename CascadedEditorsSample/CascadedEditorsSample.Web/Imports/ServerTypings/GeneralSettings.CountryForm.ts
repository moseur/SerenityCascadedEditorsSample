namespace CascadedEditorsSample.GeneralSettings {
    export interface CountryForm {
        CountryName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class CountryForm extends Serenity.PrefixedContext {
        static formKey = 'GeneralSettings.Country';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CountryForm.init)  {
                CountryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(CountryForm, [
                    'CountryName', w0,
                    'Description', w0
                ]);
            }
        }
    }
}
