using APBD_Cw2.Enums;

namespace APBD_Cw2.Models;

public abstract class Equipment(string name, EquipmentType equipmentType)
{
    private static int _nextId = 1;
    
    public int Id { get; } = _nextId++;
    public string Name { get; set; } = name;
    public EquipmentStatus Status { get; set; } = EquipmentStatus.Available;
    public EquipmentType Type { get; } = equipmentType;
}