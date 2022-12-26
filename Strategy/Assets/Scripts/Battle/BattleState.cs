using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : MonoBehaviour{

    public Combatant foe;
    public Combatant player;

    public HealthBar foeHealthBar;
    public HealthBar playerHealthBar;

    private void Awake() {
        foe.health = foe.maxHealth;
        foeHealthBar.SetMaxHealth(foe.maxHealth);
        player.health = player.maxHealth;
        playerHealthBar.SetMaxHealth(player.maxHealth);
    }

}
