using UnityEngine;
using System.Collections;

public class BaseEquiment :  BaseStatItem {

    EquipmentTypes _equipementType;
    int _spellEfectID;

    public EquipmentTypes EquipementType
    {
        get
        {
            return _equipementType;
        }

        set
        {
            _equipementType = value;
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
