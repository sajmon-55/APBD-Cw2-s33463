namespace APBD_Cw2.Exceptions;

public class EquipmentUnavailableException(int equipmentId)
    : Exception($"Equipment with id {equipmentId}  is not available.");