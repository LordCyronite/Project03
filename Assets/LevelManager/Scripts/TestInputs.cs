using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestInputs : MonoBehaviour
{
    public PlayerData _player;

    public PlayerHealth _playerHealth;

    public PlayerMana _playerMana;

    public GameObject _characterMenu;

    public bool _menuUp = false;

    public MenuControls _menuControls;

    public void Start()
    {
        _characterMenu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _player.XPGain(50);
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            _player.UpdateStats();

            if (_menuUp == false)
            {
                _characterMenu.SetActive(true);
                _menuControls.DisableTabs();
                _menuUp = true;
            } else if (_menuUp == true)
            {
                _characterMenu.SetActive(false);
                _menuUp = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            _playerHealth.TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _playerMana.CastSpell(10);
        }
    }

}
