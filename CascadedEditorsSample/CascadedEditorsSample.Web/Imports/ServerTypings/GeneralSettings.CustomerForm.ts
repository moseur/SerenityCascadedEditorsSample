namespace CascadedEditorsSample.GeneralSettings {
    export interface CustomerForm {
        CustomerName: Serenity.StringEditor;
        CountryId: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
    }

    export class CustomerForm extends Serenity.PrefixedContext {
        static formKey = 'GeneralSettings.Customer';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomerForm.init)  {
                CustomerForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(CustomerForm, [
                    'CustomerName', w0,
                    'CountryId', w1,
                    'CityId', w1,
                    'DistrictId', w1
                ]);
            }
        }
    }
}
