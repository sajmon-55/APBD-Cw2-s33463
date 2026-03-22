using APBD_Cw2.Enums;

namespace APBD_Cw2.Models.Equipments;

public class Mouse(string name, int dpi, bool isWireless) : Equipment(name, EquipmentType.Mouse)
{
    public int Dpi { get; } = dpi;
    public bool IsWireless { get; } = isWireless;
}