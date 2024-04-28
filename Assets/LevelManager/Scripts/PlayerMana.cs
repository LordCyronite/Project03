using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMana : MonoBehaviour
{
    [SerializeField] private int _maxMana;

    [SerializeField] private int _currentMana;

    private PlayerData _playerData;

    [SerializeField] private TextMeshProUGUI _currentManaTextView;

    bool Dead = false;

    private void Start()
    {
        _playerData = GameObject.Find("Player").GetComponent<PlayerData>();

        _maxMana = _playerData._MaxMana;

        _currentMana = _maxMana;

        _currentManaTextView.text = "Mana: " + _currentMana.ToString();
    }

    public void UpdateCurrentMana()
    {
        _playerData = GameObject.Find("Player").GetComponent<PlayerData>();

        _maxMana = _playerData._MaxMana;

        _currentMana = _maxMana;

        _currentManaTextView.text = "Mana: " + _currentMana.ToString();
    }

    public void CastSpell(int manaAmount)
    {
        _currentMana -= manaAmount;
        _currentManaTextView.text = "Mana: " + _currentMana.ToString();
        if (_currentMana <= 0)
        {
            _currentMana = 0;
            _currentManaTextView.text = "Mana: " + _currentMana.ToString();
        }
    }
}
