using APBD_Cw2.Enums;

namespace APBD_Cw2.Models.Equipments;

public class Headset(string name, bool hasMicrophone, bool isWireless) 
    : Equipment (name, EquipmentType.Headset)
{
    public bool HasMicrophone { get; } = hasMicrophone;
    public bool IsWireless { get; } = hasMicrophone;
}