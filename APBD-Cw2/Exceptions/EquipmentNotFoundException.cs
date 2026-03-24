namespace APBD_Cw2.Exceptions;

public class EquipmentNotFoundException(int equipmentId)
    : Exception($"error: Equipment with id {equipmentId} not found.");