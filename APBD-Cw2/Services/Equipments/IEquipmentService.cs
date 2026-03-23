using APBD_Cw2.Enums;
using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Equipments;

public interface IEquipmentService
{
    public void AddEquipment(Equipment equipment);
    public Equipment GetEquipmentById(int equipmentId);
    public List<Equipment> GetAll();
    public List<Equipment> GetAllByType(EquipmentType equipmentType);
    public List<Equipment> GetAvailable();
    public void SetAvailable(int equipmentId);
    public void SetUnavailable(int equipmentId);
    
}