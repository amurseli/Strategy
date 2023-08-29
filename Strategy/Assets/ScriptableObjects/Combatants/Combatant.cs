using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Data", menuName = "Custom Data/New Combatant")]
public class Combatant : ScriptableObject
{
    public string _name;
    public int hp;
    public int level;
    public int baseAttack;
    public int baseDefense;
    public int baseSpeed;
    public Sprite characterSprite;

    public int getStat(int _base){
        return (int) Mathf.Floor((0.01f *((2*(float)_base) * level) + 5));
    }
}