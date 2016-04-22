using UnityEngine;
using System.Collections;

public class BaseTrinket : BaseStatItem
{
    TrinketTypes _trinketType;
    int _spellEfectID;

    private TrinketTypes TrinketTypes
    {
        get
        {
            return _trinketType;
        }

        set
        {
            _trinketType = value;
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
