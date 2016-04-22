using UnityEngine;
using System.Collections;

public class InformationCharacter : MonoBehaviour {

    private InfoCharactersStates _currentStates;
    private DisplayInformation _displayInformation = new DisplayInformation();
    private BaseHerosClass _hero;

    void Start()
    {
        _currentStates = InfoCharactersStates.InfoCharacter;
        CreateHeros();

    }
    void Update()
    {
        switch (_currentStates)
        {
            case InfoCharactersStates.InfoCharacter:
                break;
            case InfoCharactersStates.StatsCharacter:
                break;
            case InfoCharactersStates.Image:
                break;
            default:
                break;
        }
    }
    void OnGUI()
    {
        if (_currentStates == InfoCharactersStates.InfoCharacter)
        {
            _displayInformation.DisplayNameInformation(_hero);
            _displayInformation.DisplayStatsInformation(_hero);
            _displayInformation.DisplayImageInformation(_hero);
        }
        else if (_currentStates == InfoCharactersStates.StatsCharacter)
        {
            _displayInformation.DisplayStatsInformation(_hero);
        }
        else if (_currentStates == InfoCharactersStates.Image)
        {
            //_displayInformation.DisplayImageInformation();
        }
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
