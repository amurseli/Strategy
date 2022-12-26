using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AttackButton3 : MonoBehaviour, IPointerClickHandler
{
    public CombatManager combat;

    public void OnPointerClick (PointerEventData eventData)
    {
        combat.computeTurn(combat.battleState, combat.battleState.player.move3, combat.battleState.foe.move1);
    }
}
