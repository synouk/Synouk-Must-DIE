﻿using UnityEngine;
using System.Collections;
using System;

public class WarriorClass : BaseHerosClass {

    public WarriorClass()
    {
        CharacterName = "George";
        CharacterClassName = "Warrior";
        Lvl = 0;
        HP = 50;
        HPmax = 50;
        Mana = 20;
        ManaMax = 20;
        Damage = 11;
        CritChance = 22;
        Speed = 5;
        HitChance = 60;
        AffectRes = 30;
        BleedingRes = 45;
        MagicRes = 20;
        FireRes = 20;
        PoisonRes = 20;
        WaterRes = 20;
        Defense = 40;
        DodgeChance = 15;
        Evilness = 0;
        Xp = 0;
        XpMax = 100;
        Sickness = "";
        Relation = "";
        Psycho = "";
        Equipement[0] = "UNE GROSSE BITE";
        Equipement[1] = "UN BON GROS STRING MA GUEULE";
    }
    public override void LevelUp()
    {
        if (XpMax > Xp)
            throw new ArgumentException("Hero can't level up don't use this function when XpMax > Xp");
        Lvl++;
        Xp = Xp - XpMax;
        XpMax = XpMax * 2;

        HPmax += 15;
        ManaMax += 6;
        Damage += 4;
        HitChance += 20;
        DodgeChance += 5;
    }
}
