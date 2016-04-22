using UnityEngine;
using System.Collections;

public class CreateEquipment : MonoBehaviour
{
    BaseEquiment _baseEquipment;
    void Start()
    {
        CreateNewEquipment();
        Debug.Log("Item Description : " + _baseEquipment.ItemDescription);
        Debug.Log("Item ID : " + _baseEquipment.ItemID);
        Debug.Log("Item Name : " + _baseEquipment.ItemName);
        Debug.Log("Item Type : " + _baseEquipment.ItemType);
        Debug.Log("Max Heal Bonus : " + _baseEquipment.MaxHealth);
        Debug.Log("Max Physical Defense : " + _baseEquipment.PhysicalDefense);
        Debug.Log("Strength : " + _baseEquipment.Strength);
        Debug.Log("SpellEffectID : " + _baseEquipment.SpellEfectID);
        Debug.Log("Weapon Type : " + _baseEquipment.EquipementType);
    }

    public void CreateNewEquipment()
    {
        _baseEquipment = new BaseEquiment();

        ChooseWeaponType();

        // BaseItemProperties
        _baseEquipment.ItemName = _baseEquipment.EquipementType.ToString() + Random.Range(1, 101).ToString();
        _baseEquipment.ItemDescription = "This is a new" + _baseEquipment.EquipementType.ToString();
        _baseEquipment.ItemID = Random.Range(1, 101);
        _baseEquipment.ItemType = ItemTypes.Equipement;

        //BaseStatProperties
        _baseEquipment.MaxHealth = Random.Range(1, 51);
        _baseEquipment.PhysicalDefense = Random.Range(1, 51);
        _baseEquipment.MagicalDefense = Random.Range(1, 51);
        _baseEquipment.Strength = Random.Range(1, 11);

        _baseEquipment.SpellEfectID = Random.Range(1, 111);
    }

    private void ChooseWeaponType()
    {
        int equipmentType = Random.Range(1, 3);
        _baseEquipment.EquipementType = (EquipmentTypes)equipmentType;
    }
}
