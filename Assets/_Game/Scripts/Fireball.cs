using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public MenuControls _upgradeMenu;
    public PlayerData _playerData;
    public PlayerMana _playerMana;

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
    }
}
