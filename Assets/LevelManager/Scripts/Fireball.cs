using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public MenuControls _upgradeMenu;
    public PlayerData _playerData;
    public PlayerMana _playerMana;
    public GameObject _fireball;

    public void Start()
    {
        _fireball.SetActive(false);
    }

    void DisableFireball()
    {
        _fireball.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1) && _upgradeMenu._FireballUnlock == true)
        {
            CastFireball();
        }
    }
    
    public void CastFireball()
    {
        _playerMana.CastSpell(5);
        _fireball.SetActive(true);
        Invoke("DisableFireball", 1f);
    }
}
