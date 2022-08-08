
namespace CascadedEditorsSample.GeneralSettings {

    @Serenity.Decorators.registerClass()
    export class DistrictGrid extends Serenity.EntityGrid<DistrictRow, any> {
        protected getColumnsKey() { return DistrictColumns.columnsKey; }
        protected getDialogType() { return DistrictDialog; }
        protected getIdProperty() { return DistrictRow.idProperty; }
        protected getInsertPermission() { return DistrictRow.insertPermission; }
        protected getLocalTextPrefix() { return DistrictRow.localTextPrefix; }
        protected getService() { return DistrictService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}