using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class DisplayInformation
{
    GUIStyle _style = new GUIStyle();
    public void DisplayNameInformation( BaseHerosClass hero)
    {
        InitializeGUIStyle();
        GUI.Label(new Rect(150, 150, 400, 400),"Type : " + hero.CharacterClassName, _style);
        GUI.Label(new Rect(150, 180, 400, 400), "Nom : " + hero.CharacterName, _style);
        int lvl = hero.Lvl + 1;
        GUI.Label(new Rect(150, 210, 400, 400), "Level : " + lvl, _style);
        GUI.Label(new Rect(150, 240, 400, 400), "Vie : " + hero.HP + " / " + hero.HPmax , _style);
        GUI.Label(new Rect(150, 270, 400, 400), "Mana : " + hero.Mana + " / " + hero.ManaMax, _style);
        GUI.Label(new Rect(150, 300, 400, 400), "Méchanceté : " + hero.Evilness + " / 100", _style);
        GUI.Label(new Rect(150, 330, 400, 400), "Xp : " + hero.Xp + " / " + hero.XpMax, _style);
    }
    public void DisplayStatsInformation(BaseHerosClass hero)
    {
        GUI.Label(new Rect(400, 150, 400, 400), "Stats offensives", _style);
        GUI.Label(new Rect(400, 180, 400, 400), "Damage : " + hero.Damage, _style);
        GUI.Label(new Rect(400, 210, 400, 400), "Defense : " + hero.Defense, _style);
        GUI.Label(new Rect(400, 240, 400, 400), "Crit Chance : " + hero.CritChance, _style);
        GUI.Label(new Rect(400, 270, 400, 400), "Chance de toucher : " + hero.HitChance, _style);
        GUI.Label(new Rect(400, 300, 400, 400), "Vitesse : " + hero.Speed, _style);

        GUI.Label(new Rect(650, 150, 400, 400), "Resistance", _style);
        GUI.Label(new Rect(650, 180, 400, 400), "Affect resit : " + hero.AffectRes, _style);
        GUI.Label(new Rect(650, 210, 400, 400), "Saignement resit : " + hero.BleedingRes, _style);
        GUI.Label(new Rect(650, 240, 400, 400), "Fire resit : " + hero.FireRes, _style);
        GUI.Label(new Rect(650, 270, 400, 400), "Resit au poison : " + hero.PoisonRes, _style);
        GUI.Label(new Rect(650, 300, 400, 400), "Resit à l'eau : " + hero.WaterRes, _style);

        GUI.Label(new Rect(900, 150, 400, 400), "Stats Defensives", _style);
        GUI.Label(new Rect(900, 180, 400, 400), "Defense : " + hero.Defense, _style);
        GUI.Label(new Rect(900, 210, 400, 400), "Chance d'esquive : " + hero.DodgeChance, _style);

    }
    public void DisplayImageInformation(BaseHerosClass hero)
    {
        Texture2D img = Resources.Load("S_Buff01") as Texture2D;
        if (img != null)
        {
            GUI.DrawTexture(new Rect(900, 230, 100, 100), img);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 1001, 100), "error");
        }
    }
    public void InitializeGUIStyle()
    {
        _style.fontSize = 16;
    }
}
