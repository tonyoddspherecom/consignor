namespace Consignor.ShipmentServer
{
    public enum ShipmentConnectionKind
    {
        eSckUnknown,
        eSckChildIsComeback,
        eSckChildIsGroupMember,
        eSckChildIsCompletionSub,
        eSckChildIsBulksplitSub
    }
}