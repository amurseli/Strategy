using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AttackButton1 : MonoBehaviour, IPointerClickHandler
{
    public CombatManager combat;

    public void OnPointerClick (PointerEventData eventData)
    {
        //falta plantear la IA del enemigo, por ahora es aleatoria
        combat.computeTurn(combat.battleState, combat.battleState.player.move1, combat.battleState.foe.move2);
    }
}
