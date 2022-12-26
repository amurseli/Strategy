using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : MonoBehaviour{

    public Combatant foe;
    public Combatant player;

    private void Awake() {
        foe.health = foe.maxHealth;
        player.health = player.maxHealth;
    }

}
