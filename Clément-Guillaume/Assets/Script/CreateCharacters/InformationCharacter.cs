using UnityEngine;
using System.Collections;

public class InformationCharacter : MonoBehaviour {

    private DisplayInformation _displayInformation;
    private BaseHerosClass _hero;

    void Start()
    {
        CreateHeros();
        _displayInformation = new DisplayInformation(_hero);
    }
    void Update()
    {

    }
    void OnGUI()
    {
        _displayInformation.RefreshGUI();
    }
    void CreateHeros()
    {
        int rand = Random.Range(1, 3);
        if (rand == 1)
        {
            _hero = new WarriorClass();
        }
        else
        {
            _hero = new PaladinClass();
        }
    }
}
