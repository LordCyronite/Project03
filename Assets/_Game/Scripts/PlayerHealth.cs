using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    [SerializeField] private int _currentHealth;

    public PlayerData _playerData;

    [SerializeField] private TextMeshProUGUI _currentHealthTextView;

    bool Dead = false;

    private void Start()
    {
        _playerData = GameObject.Find("Player").GetComponent<PlayerData>();

        _maxHealth = _playerData._MaxHealth;

        _currentHealth = _maxHealth;

        _currentHealthTextView.text = "Health: " + _currentHealth.ToString();
    }

    public void UpdateCurrentHealth()
    {
        _playerData = GameObject.Find("Player").GetComponent<PlayerData>();

        _maxHealth = _playerData._MaxHealth;

        _currentHealth = _maxHealth;

        _currentHealthTextView.text = "Health: " + _currentHealth.ToString();
    }

    public void TakeDamage(int damageAmount)
    {
        _currentHealth -= damageAmount;
        _currentHealthTextView.text = "Health: " + _currentHealth.ToString();
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            _currentHealthTextView.text = "Health: " + _currentHealth.ToString();
            Dead = true;
        }
    }
}
