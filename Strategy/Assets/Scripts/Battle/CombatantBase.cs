using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatantBase 
{
    public Combatant _base; //Aunque se llame combatatant base, los nombres estan puestos al reves, asi que CombatantBase tiene a Combatant en _base
    int _level;

    private CombatantBase rival;

    public AttackStrategy move1;
    public AttackStrategy move2;
    public AttackStrategy move3;
    public AttackStrategy move4;

    public CombatantStatistic Attack;
    public CombatantStatistic Defense;

    public float health;


    public CombatantBase(Combatant _base,int _level){
        this._base = _base;
        this._level = _level;
        move1 = new Punch(this);
        move2 = new ConfidenceBreaker(this);
        health = MaxHealth;
        setStats();
    }

    private void setStats(){
        Attack = new CombatantStatistic(baseStatToEffectiveStat(_base.bAttack));
        Defense = new CombatantStatistic(baseStatToEffectiveStat(_base.bDefense));
    }

    private int baseStatToEffectiveStat(float baseValue){
        return Mathf.FloorToInt((( baseValue * 2) * _level) / 100f) + 10 + _level;
    }

    public float MaxHealth{
        get { return Mathf.FloorToInt((_base.maxHealth * _level) / 100f) + 5; }
    }

    public void setRival(CombatantBase rival){
        this.rival = rival;
    }

    public CombatantBase getRival(){
        return this.rival;
    }

    public float getHealth(){
        return health;
    }

    public void setHealth(float health){
        this.health = health;
    }

    public int getLevel(){
        return _level;
    }

    public void recieveDamage(float damage){
        health = health - damage;
    }

}
