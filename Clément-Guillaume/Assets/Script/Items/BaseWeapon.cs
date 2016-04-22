using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

    WeaponTypes _weaponType;
    int _spellEfectID;

    public WeaponTypes WeaponType
    {
        get
        {
            return _weaponType;
        }

        set
        {
            _weaponType = value;
        }
    }

    public int SpellEfectID
    {
        get
        {
            return _spellEfectID;
        }

        set
        {
            _spellEfectID = value;
        }
    }
}
