using APBD_Cw2.Enums;
using APBD_Cw2.Exceptions;
using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Equipments;

public class EquipmentService : IEquipmentService
{
    private readonly List<Equipment> _equipments = [];
    
    public void AddEquipment(Equipment equipment)
    {
        _equipments.Add(equipment);
    }

    public Equipment GetEquipmentById(int equipmentId)
    {
        return _equipments.FirstOrDefault(x => x.Id == equipmentId)
            ?? throw new EquipmentNotFoundException(equipmentId);
    }

    public List<Equipment> GetAll()
    {
        return _equipments;
    }

    public List<Equipment> GetAllByType(EquipmentType equipmentType)
    {
        return _equipments.Where(e => e.Type == equipmentType).ToList();
    }

    public List<Equipment> GetAvailable()
    {
        return _equipments.Where(e => e.Status == EquipmentStatus.Available).ToList();
    }

    public void SetAvailable(int equipmentId)
    {
        GetEquipmentById(equipmentId).Status = EquipmentStatus.Available;
    }

    public void SetUnavailable(int equipmentId)
    {
        GetEquipmentById(equipmentId).Status = EquipmentStatus.Unavailable;
    }

    public void DamagedEquipment(int equipmentId)
    {
        if (GetEquipmentById(equipmentId).IsDamaged)
        {
            GetEquipmentById(equipmentId).Status = EquipmentStatus.Unavailable;
        }
        else
        {
            Console.WriteLine($"{GetEquipmentById(equipmentId).Name} is not damaged");
        }
    }
}