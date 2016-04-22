using UnityEngine;
using System.Collections;

public class BasePotion : BaseItem {

    PotionTypes _potionType;
    int _spellEffectID;

    private PotionTypes PotionType
    {
        get
        {
            return _potionType;
        }

        set
        {
            _potionType = value;
        }
    }

    public int SpellEffectID
    {
        get
        {
            return _spellEffectID;
        }

        set
        {
            _spellEffectID = value;
        }
    }
}
