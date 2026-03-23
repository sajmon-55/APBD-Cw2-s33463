using APBD_Cw2.Enums;

namespace APBD_Cw2.Models.Equipments;

public class Keyboard(string name, string color, bool hasBackLight) : Equipment(name, EquipmentType.Keyboard)
{
    public string Color { get; } = color;
    public bool HasBackLight { get; } = hasBackLight;
}