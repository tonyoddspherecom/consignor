namespace Consignor.ShipmentServer
{
    public enum AddressKind
    {
        eSakUnknown,
        eSakReceiver,
        eSakSender,
        eSakPickUp,
        eSakPayer,
        eSakBuyer,
        eSakTemporary,
        eSakMessage,
        eSakForwarder,
        eSakReturnTo,
        eSakDropPoint,
        eSakDepot,
        eSakComeback
    }
}