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

    public float initAttack;
    public float initDefense;

    [SerializeField] public float bAttack;
    [SerializeField] public float bDefense;

    //stats

    public float maxHealth = 50;

    public CombatantStatistic attack = new CombatantStatistic(10);
    public CombatantStatistic defense = new CombatantStatistic(10);


    public Combatant(){
        attack = new CombatantStatistic(initAttack);
        defense = new CombatantStatistic(initDefense);

    }

    public void SetStatistics(){
        attack = new CombatantStatistic(initAttack);
        defense = new CombatantStatistic(initDefense);

    }

    private void Start() {
    }




}

