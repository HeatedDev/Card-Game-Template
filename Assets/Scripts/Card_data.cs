using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card_data", menuName = "Cards/Card_data", order = 1)]
public class Card_data : ScriptableObject
{
    public string card_name;
    public string description;
    public int normal_health;
    public int cost;
    public int health;
    public int damage;
    public int normal_damage;
    public bool evolved;
    public Sprite sprite;

}
