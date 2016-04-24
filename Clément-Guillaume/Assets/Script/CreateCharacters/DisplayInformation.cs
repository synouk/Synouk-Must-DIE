using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class DisplayInformation
{
    BaseHerosClass _hero;
    GUIStyle _style = new GUIStyle();
    string _xp;
    string _xpMax;

    public DisplayInformation(BaseHerosClass hero)
    {
        _hero = hero;
        _xp = _hero.Xp.ToString();
        _xpMax = _hero.XpMax.ToString();
    }

    public void RefreshGUI()
    {
        DisplayNameInformation();
        DisplayStatsInformation();
        DisplayImageInformation();
        DisplayXpInformation();
        DisplayButtonForXp();
    }
    private void DisplayNameInformation()
    {
        InitializeGUIStyle();
        GUI.Label(new Rect(150, 150, 400, 400),"Type : " + _hero.CharacterClassName, _style);
        GUI.Label(new Rect(150, 180, 400, 400), "Nom : " + _hero.CharacterName, _style);
        GUI.Label(new Rect(150, 240, 400, 400), "Vie : " + _hero.HP + " / " + _hero.HPmax , _style);
        GUI.Label(new Rect(150, 270, 400, 400), "Mana : " + _hero.Mana + " / " + _hero.ManaMax, _style);
        GUI.Label(new Rect(150, 300, 400, 400), "Méchanceté : " + _hero.Evilness + " / 100", _style);

    }

    private void DisplayStatsInformation()
    {
        GUI.Label(new Rect(400, 150, 400, 400), "Stats offensives", _style);
        GUI.Label(new Rect(400, 180, 400, 400), "Damage : " + _hero.Damage, _style);
        GUI.Label(new Rect(400, 210, 400, 400), "Defense : " + _hero.Defense, _style);
        GUI.Label(new Rect(400, 240, 400, 400), "Crit Chance : " + _hero.CritChance, _style);
        GUI.Label(new Rect(400, 270, 400, 400), "Chance de toucher : " + _hero.HitChance, _style);
        GUI.Label(new Rect(400, 300, 400, 400), "Vitesse : " + _hero.Speed, _style);

        GUI.Label(new Rect(650, 150, 400, 400), "Resistance", _style);
        GUI.Label(new Rect(650, 180, 400, 400), "Affect resit : " + _hero.AffectRes, _style);
        GUI.Label(new Rect(650, 210, 400, 400), "Saignement resit : " + _hero.BleedingRes, _style);
        GUI.Label(new Rect(650, 240, 400, 400), "Fire resit : " + _hero.FireRes, _style);
        GUI.Label(new Rect(650, 270, 400, 400), "Resit au poison : " + _hero.PoisonRes, _style);
        GUI.Label(new Rect(650, 300, 400, 400), "Resit à l'eau : " + _hero.WaterRes, _style);

        GUI.Label(new Rect(900, 150, 400, 400), "Stats Defensives", _style);
        GUI.Label(new Rect(900, 180, 400, 400), "Defense : " + _hero.Defense, _style);
        GUI.Label(new Rect(900, 210, 400, 400), "Chance d'esquive : " + _hero.DodgeChance, _style);

    }
    private void DisplayImageInformation()
    {
        Texture2D img = Resources.Load("Heros/" + _hero.CharacterIcon) as Texture2D;
        if (img != null)
        {
            GUI.DrawTexture(new Rect(900, 230, 100, 100), img);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 1001, 100), "error");
        }
    }
    private void DisplayXpInformation()
    {
        int lvl = _hero.Lvl + 1;
        GUI.Label(new Rect(150, 210, 400, 400), "Level : " + lvl, _style);
        GUI.Label(new Rect(150, 330, 400, 400), "Xp : " + _hero.Xp.ToString() + " / " + _hero.XpMax.ToString(), _style);
    }
    private void DisplayButtonForXp()
    {
        if (GUI.Button(new Rect(120, 330, 20, 20), " - "))
        {
            RemoveXpButtonClick();
        }
        if (GUI.Button(new Rect(250, 330, 20, 20), " + "))
        {
            AddXpButtonClick();
        }
    }

    private void AddXpButtonClick()
    {
        if (_hero.Xp == _hero.XpMax)
        {
            _hero.LevelUp();
        }
        _hero.Xp = _hero.Xp + 50;
    }

    private void RemoveXpButtonClick()
    {
        if(_hero.Xp > 0 )
        {
            _hero.Xp--;
        }
    }

    private void InitializeGUIStyle()
    {
        _style.fontSize = 16;
    }
}
