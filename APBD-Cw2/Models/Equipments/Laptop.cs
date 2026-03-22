using APBD_Cw2.Enums;

namespace APBD_Cw2.Models.Equipments;

public class Laptop(string name, int ramSize, string processor) : Equipment(name, EquipmentType.Laptop)
{
    public int RamSize { get; } = ramSize;
    public string Processor { get; } = processor;
}