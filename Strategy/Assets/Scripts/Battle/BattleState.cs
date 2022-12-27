using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : MonoBehaviour{


    public Combatant foeData;
    public Combatant playerData;

    [HideInInspector]
    public CombatantBase foe;
    [HideInInspector]
    public CombatantBase player;

    public HealthBar foeHealthBar;
    public HealthBar playerHealthBar;

    private void Start() {
        foe = new CombatantBase(foeData,5);
        player = new CombatantBase(playerData,5);
        foeHealthBar.SetMaxHealth(foe.MaxHealth);
        playerHealthBar.SetMaxHealth(player.MaxHealth);
        foe.setRival(player);
        player.setRival(foe);
    }

}
