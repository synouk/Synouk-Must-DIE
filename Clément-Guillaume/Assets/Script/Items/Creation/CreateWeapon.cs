using UnityEngine;
using System.Collections;

public class CreateWeapon : MonoBehaviour {

    BaseWeapon _baseWeapon;

    void Start()
    {
        CreateNewWeapon();
        Debug.Log("Item Description : " + _baseWeapon.ItemDescription);
        Debug.Log("Item ID : " + _baseWeapon.ItemID);
        Debug.Log("Item Name : " + _baseWeapon.ItemName);
        Debug.Log("Item Type : " + _baseWeapon.ItemType);
        Debug.Log("Max Heal Bonus : " + _baseWeapon.MaxHealth);
        Debug.Log("Max Mana Bonus : " + _baseWeapon.MaxMana);
        Debug.Log("Strength : " + _baseWeapon.Strength);
        Debug.Log("SpellEffectID : " + _baseWeapon.SpellEfectID);
        Debug.Log("Weapon Type : " + _baseWeapon.WeaponType);

    }

    public void CreateNewWeapon()
    {
        _baseWeapon = new BaseWeapon();

        // BaseItemProperties
        _baseWeapon.ItemName = "Weapon" + Random.Range(1, 101);
        _baseWeapon.ItemDescription = "This is a new weapon";
        _baseWeapon.ItemID = Random.Range(1, 101);
        _baseWeapon.ItemType = ItemTypes.Weapon;
        //BaseStatProperties
        _baseWeapon.MaxHealth = Random.Range(1, 50);
        _baseWeapon.MaxMana = Random.Range(1, 50);
        _baseWeapon.Strength = Random.Range(1, 11);

        _baseWeapon.SpellEfectID = Random.Range(1, 111);
        ChooseWeaponType();

    }

    private void ChooseWeaponType()
    {
        int weaponType = Random.Range(1, 6);
        _baseWeapon.WeaponType = (WeaponTypes)weaponType; 
    }
}
