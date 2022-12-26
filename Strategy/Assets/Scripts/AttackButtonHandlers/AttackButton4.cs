using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AttackButton4 : MonoBehaviour, IPointerClickHandler
{
    public CombatManager combat;

    public void OnPointerClick (PointerEventData eventData)
    {
        combat.computeTurn(combat.battleState, combat.battleState.player.move4, combat.battleState.foe.move1);
    }
}
