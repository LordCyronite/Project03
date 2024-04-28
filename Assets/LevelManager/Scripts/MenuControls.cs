using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuControls : MonoBehaviour
{
    public PlayerData _playerData;

    public PlayerHealth _playerHealth;

    public PlayerMana _playerMana;

    public GameObject _strTab;

    public GameObject _dexTab;

    public GameObject _conTab;

    public GameObject _intTab;

    public GameObject _wisTab;

    public GameObject _chaTab;

    [SerializeField] private TextMeshProUGUI _strText;

    [SerializeField] private TextMeshProUGUI _dexText;

    [SerializeField] private TextMeshProUGUI _conText;

    [SerializeField] private TextMeshProUGUI _intText;

    [SerializeField] private TextMeshProUGUI _wisText;

    [SerializeField] private TextMeshProUGUI _chaText;

    [SerializeField] private int _playerStr;

    [SerializeField] private int _playerDex;

    [SerializeField] private int _playerCon;

    [SerializeField] private int _playerInt;

    [SerializeField] private int _playerWis;

    [SerializeField] private int _playerCha;

    public bool _FireballUnlock = false;

    void Start()
    {
        DisableTabs();

        UpdateStats();
    }

    public void DisableTabs()
    {
        //Initializes Tabs

        _strTab.SetActive(false);

        _dexTab.SetActive(false);

        _conTab.SetActive(false);

        _intTab.SetActive(false);

        _wisTab.SetActive(false);

        _chaTab.SetActive(false);

        UpdateStats();
    }

    private void UpdateStats()
    {
        _playerStr = _playerData._Strength;

        _playerDex = _playerData._Dexterity;

        _playerCon = _playerData._Constitution;

        _playerInt = _playerData._Intelligence;

        _playerWis = _playerData._Wisdom;

        _playerCha = _playerData._Charisma;

        _strText.text = "Strength: " + _playerStr.ToString();

        _dexText.text = "Dexterity: " + _playerDex.ToString();

        _conText.text = "Constitution: " + _playerCon.ToString();

        _intText.text = "Intelligence: " + _playerInt.ToString();

        _wisText.text = "Wisdom: " + _playerWis.ToString();

        _chaText.text = "Charisma: " + _playerCha.ToString();
    }

    public void UpgradeStr()
    {
        if (_playerData._AbilityPoints >= 1)
        {
            _playerData._Strength += 1;
            _playerData._AbilityPoints -= 1;

            UpdateStats();
            _playerData.UpdateStats();
        }
    }

    public void UpgradeDex()
    {
        if (_playerData._AbilityPoints >= 1)
        {
            _playerData._Dexterity += 1;
            _playerData._AbilityPoints -= 1;

            UpdateStats();
            _playerData.UpdateStats();
        }
    }

    public void UpgradeCon()
    {
        if (_playerData._AbilityPoints >= 1)
        {
            _playerData._Constitution += 1;
            _playerData._AbilityPoints -= 1;

            UpdateStats();
            _playerData.UpdateStats();
            _playerHealth.UpdateCurrentHealth();
        }
    }

    public void UpgradeInt()
    {
        if (_playerData._AbilityPoints >= 1)
        {
            _playerData._Intelligence += 1;
            _playerData._AbilityPoints -= 1;

            UpdateStats();
            _playerData.UpdateStats();
            _playerMana.UpdateCurrentMana();
        }
    }

    public void UpgradeWis()
    {
        if (_playerData._AbilityPoints >= 1)
        {
            _playerData._Wisdom += 1;
            _playerData._AbilityPoints -= 1;

            UpdateStats();
            _playerData.UpdateStats();
        }
    }

    public void UpgradeCha()
    {
        if (_playerData._AbilityPoints >= 1)
        {
            _playerData._Charisma += 1;
            _playerData._AbilityPoints -= 1;

            UpdateStats();
            _playerData.UpdateStats();
        }
    }

    public void UnlockFireball()
    {
        if ((_playerData._PerkPoints >= 2) && (_FireballUnlock == false))
        {
            _FireballUnlock = true;
            _playerData._PerkPoints -= 2;

            UpdateStats();
            _playerData.UpdateStats();
        }
    }
}
