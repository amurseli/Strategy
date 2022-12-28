using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Combatant", menuName = "Strategy/Combatant")]
public class Combatant : ScriptableObject {
    
    //initial stats for inspector edition

    [SerializeField] string _name;
    
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    //[SerializeField] CombatantType type;

    [SerializeField] public float bAttack;
    [SerializeField] public float bDefense;

    //stats

    public float maxHealth = 50;


}

