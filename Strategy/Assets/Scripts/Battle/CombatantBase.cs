using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatantBase 
{
    Combatant _base;
    int _level;

    private CombatantBase rival;

    public AttackStrategy move1;
    public AttackStrategy move2;
    public AttackStrategy move3;
    public AttackStrategy move4;

    public float health;


    public CombatantBase(Combatant _base,int _level){
        this._base = _base;
        this._level = _level;
        move1 = new Punch(this);
        move2 = new ConfidenceBreaker(this);
        health = MaxHealth;
    }

    public CombatantStatistic Attack{
        get { return new CombatantStatistic(Mathf.FloorToInt((_base.bAttack * _level) / 100f) + 15); }
    }

    public CombatantStatistic Defense{
        get { return new CombatantStatistic(Mathf.FloorToInt((_base.bDefense * _level) / 100f) + 15); }
    }

    public float MaxHealth{
        get { return Mathf.FloorToInt((_base.maxHealth * _level) / 100f) + 5; }
    }

    public void setRival(CombatantBase rival){
        this.rival = rival;
    }

    public CombatantBase getRival(){
        Debug.Log(this.rival.Defense.getStatistic());
        return this.rival;
    }

    public float getHealth(){
        return health;
    }

    public void setHealth(float health){
        this.health = health;
    }

    public void recieveDamage(float damage){
        health = health - damage;
    }

}
