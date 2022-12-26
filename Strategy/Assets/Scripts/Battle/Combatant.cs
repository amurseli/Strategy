using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Combatant", menuName = "Strategy/Combatant", order = 0)]
public class Combatant : ScriptableObject {
    
    public HealthBar healthBar;

    public int maxHealth = 50;
    public int health;

    public int attack = 10;
    public int defense = 10;

    public AttackStrategy move1;
    public AttackStrategy move2;
    public AttackStrategy move3;
    public AttackStrategy move4;

    public Combatant(){
        move1 = new Punch();
    }

    private void Awake() {
        health = maxHealth;
        healthBar.SetMaxHealth(health);
    }

    public void recieveDamage(int damage){
        Debug.Log(damage);
        Debug.Log(health);
        health = health - damage;
        healthBar.SetHealth(health);
    }

}
