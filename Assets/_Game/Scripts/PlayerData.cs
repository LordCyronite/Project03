using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData_", menuName = "Mechanics/Player")]

public class PlayerData : MonoBehaviour
{
    [Header("General Information")]

    [SerializeField] private int _PlayerExperience = 0;

    [SerializeField] private int _PlayerLevel = 1;

    [SerializeField] private int _XPThreshhold = 100;

    [SerializeField] private int _XPDelta = 20;

    [SerializeField] private int _PlayerProficiency = 2;

    [SerializeField] private int _HealthBase = 100;

    [SerializeField] private int _ManaBase = 100;

    [SerializeField] private int _AbilityPoints = 0;

    [SerializeField] private int _PerkPoints = 0;

    [Header("Abilities")]

    [SerializeField] private int _Strength = 1;

    [SerializeField] private int _Dexterity = 1;

    [SerializeField] private int _Constitution = 1;

    [SerializeField] private int _Intelligence = 1;

    [SerializeField] private int _Wisdom = 1;

    [SerializeField] private int _Charisma = 1;

    [Header("Skills")]
    
    [SerializeField] private bool _AcrobaticsProficiency = false;
    
    [SerializeField] private bool _AnimalHandlingProficiency = false;
    
    [SerializeField] private bool _ArcanaProficiency = false;
    
    [SerializeField] private bool _AthleticsProficiency = false;

    [SerializeField] private bool _ComputersProficiency = false;

    [SerializeField] private bool _DeceptionProficiency = false;

    [SerializeField] private bool _EngineeringProficiency = false;

    [SerializeField] private bool _HistoryProficiency = false;

    [SerializeField] private bool _InsightProficiency = false;

    [SerializeField] private bool _IntimidationProficiency = false;

    [SerializeField] private bool _InvestigationProficiency = false;

    [SerializeField] private bool _MagicProficiency = false;

    [SerializeField] private bool _MedicineProficiency = false;

    [SerializeField] private bool _MeleeWeaponProficiency = false;

    [SerializeField] private bool _NatureProficiency = false;

    [SerializeField] private bool _PilotingProficiency = false;

    [SerializeField] private bool _PerceptionProficiency = false;

    [SerializeField] private bool _PerformanceProficiency = false;

    [SerializeField] private bool _RangedWeaponProficiency = false;

    [SerializeField] private bool _ReligionProficiency = false;

    [SerializeField] private bool _ScienceProficiency = false;

    [SerializeField] private bool _SlightOfHandProficiency = false;

    [SerializeField] private bool _StealthProficiency = false;

    [SerializeField] private bool _SurvivalProficiency = false;

    public void XPGain(int XPGained)
    {
        _PlayerExperience += XPGained;

        if (_PlayerExperience >= (_XPThreshhold + (_XPDelta * _PlayerLevel)))
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        _PlayerExperience = 0;

        _AbilityPoints += 1;

        _PerkPoints += 5;
    }


    public void Update()
    {

        //Skill Level Manager

        int _Acrobatics;
        if (_AcrobaticsProficiency == true)
        {
            _Acrobatics = _Dexterity + _PlayerProficiency;
        }
        else
        {
            _Acrobatics = _Dexterity;
        }


        int _AnimalHandling;
        if (_AnimalHandlingProficiency == true)
        {
            _AnimalHandling = _Wisdom + _PlayerProficiency;
        }
        else
        {
            _AnimalHandling = _Wisdom;
        }


        int _Arcana;
        if (_ArcanaProficiency == true)
        {
            _Arcana = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Arcana = _Intelligence;
        }


        int _Athletics;
        if (_AthleticsProficiency == true)
        {
            _Athletics = _Strength + _PlayerProficiency;
        }
        else
        {
            _Athletics = _Strength;
        }


        int _Computers;
        if (_ComputersProficiency == true)
        {
            _Computers = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Computers = _Intelligence;
        }


        int _Deception;
        if (_DeceptionProficiency == true)
        {
            _Deception = _Charisma + _PlayerProficiency;
        }
        else
        {
            _Deception = _Charisma;
        }


        int _Engineering;
        if (_EngineeringProficiency == true)
        {
            _Engineering = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Engineering = _Intelligence;
        }


        int _History;
        if (_HistoryProficiency == true)
        {
            _History = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _History = _Intelligence;
        }


        int _Insight;
        if (_InsightProficiency == true)
        {
            _Insight = _Wisdom + _PlayerProficiency;
        }
        else
        {
            _Insight = _Wisdom;
        }


        int _Intimidation;
        if (_IntimidationProficiency == true)
        {
            _Intimidation = _Charisma + _PlayerProficiency;
        }
        else
        {
            _Intimidation = _Charisma;
        }


        int _Investigation;
        if (_ArcanaProficiency == true)
        {
            _Investigation = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Investigation = _Intelligence;
        }


        int _Magic;
        if (_MagicProficiency == true)
        {
            _Magic = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Magic = _Intelligence;
        }


        int _Medicine;
        if (_MedicineProficiency == true)
        {
            _Medicine = _Wisdom + _PlayerProficiency;
        }
        else
        {
            _Medicine = _Wisdom;
        }


        int _MeleeWeapon;
        if (_MeleeWeaponProficiency == true)
        {
            _MeleeWeapon = _Strength + _PlayerProficiency;
        }
        else
        {
            _MeleeWeapon = _Strength;
        }


        int _Nature;
        if (_NatureProficiency == true)
        {
            _Nature = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Nature = _Intelligence;
        }


        int _Piloting;
        if (_PilotingProficiency == true)
        {
            _Piloting = _Dexterity + _PlayerProficiency;
        }
        else
        {
            _Piloting = _Dexterity;
        }


        int _Perception;
        if (_PerceptionProficiency == true)
        {
            _Perception = _Wisdom + _PlayerProficiency;
        }
        else
        {
            _Perception = _Wisdom;
        }


        int _Performance;
        if (_PerformanceProficiency == true)
        {
            _Performance = _Charisma + _PlayerProficiency;
        }
        else
        {
            _Performance = _Charisma;
        }


        int _RangedWeapon;
        if (_RangedWeaponProficiency == true)
        {
            _RangedWeapon = _Dexterity + _PlayerProficiency;
        }
        else
        {
            _RangedWeapon = _Dexterity;
        }


        int _Religion;
        if (_ReligionProficiency == true)
        {
            _Religion = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Religion = _Intelligence;
        }


        int _Science;
        if (_ScienceProficiency == true)
        {
            _Science = _Intelligence + _PlayerProficiency;
        }
        else
        {
            _Science = _Intelligence;
        }


        int _SlightOfHand;
        if (_SlightOfHandProficiency == true)
        {
            _SlightOfHand = _Dexterity + _PlayerProficiency;
        }
        else
        {
            _SlightOfHand = _Dexterity;
        }


        int _Stealth;
        if (_StealthProficiency == true)
        {
            _Stealth = _Dexterity + _PlayerProficiency;
        }
        else
        {
            _Stealth = _Dexterity;
        }


        int _Survival;
        if (_SurvivalProficiency == true)
        {
            _Survival = _Wisdom + _PlayerProficiency;
        }
        else
        {
            _Survival = _Wisdom;
        }

        //Stat Manager

        int _MaxHeath = _HealthBase + (_Constitution * 10);

        int _MaxMana = _ManaBase + (_Intelligence * 10);

    }

}
