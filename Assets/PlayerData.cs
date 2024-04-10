using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData_", menuName = "Mechanics/Player")]

public class PlayerData : ScriptableObject
{
    [Header("General Information")]

    [SerializeField] private int _PlayerExperience;

    [SerializeField] private int _PlayerLevel;
}
