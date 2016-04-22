using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

    private int _maxHealth;
    private int _maxMana;
    private int _strength;
    private int _physicalDefense;
    private int _magicalDefense;

    public int MaxHealth
    {
        get
        {
            return _maxHealth;
        }

        set
        {
            _maxHealth = value;
        }
    }

    public int MaxMana
    {
        get
        {
            return _maxMana;
        }

        set
        {
            _maxMana = value;
        }
    }

    public int Strength
    {
        get
        {
            return _strength;
        }

        set
        {
            _strength = value;
        }
    }

    public int PhysicalDefense
    {
        get
        {
            return _physicalDefense;
        }

        set
        {
            _physicalDefense = value;
        }
    }

    public int MagicalDefense
    {
        get
        {
            return _magicalDefense;
        }

        set
        {
            _magicalDefense = value;
        }
    }
}
