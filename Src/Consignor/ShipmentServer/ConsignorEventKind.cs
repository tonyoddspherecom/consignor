namespace Consignor.ShipmentServer
{
    public enum ConsignorEventKind
    {
        eSskUnknown,
        eSskCreatedByImport,
        eSskCreateByGUI,
        eSskCreateByAPI,
        eSskSubmitted,
        eSskPriceCalculated,
        eSskBatchCreated,
        eSskFreightBillPrinted,
        eSskPackageLabelPrinted,
        eSskChangedAfterPackageLabelPrinted,
        eSskDeletedBeforeBatchCreated,
        eSskDeletedAfterBatchCreated,
        eSskEdiFileCreated,
        eSskEdiFileTransmitted,
        eSskMailbackRequested,
        eSskMailbackSent,
        eSskTransmitRequested,
        eSskTransmitSucceeded,
        eSskTransmitFailed,
        eSskProductionDraft,
        eSskMailbackFailed,
        eSskMoving,
        eSskDelivered,
        eSskDocumentReprinted,
        eSskMailbackDeleted,
        eSskShipmentLabelPrinted,
        eSskPrintedInConline,
        eSskPrebookSucceeded,
        eSskPrebookFailed
    }
}