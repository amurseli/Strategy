using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AttackButton2 : MonoBehaviour, IPointerClickHandler
{
    public CombatManager combat;

    public void OnPointerClick (PointerEventData eventData)
    {
        combat.computeTurn(combat.battleState, combat.battleState.player.move2, combat.battleState.foe.move2);
    }
}
