using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public LayerMask playerLayer;
    public GameObject battleObjects;
    public BattleSystem battleSystem;
 
    private void Update() {
        if(!battleSystem.getBattleState()){
            if(Physics2D.OverlapCircle(transform.position, 0.3f, playerLayer) != null){
                battleObjects.SetActive(true);
                battleSystem.StartBattle(gameObject);
            }
        }
    }

    public void defeat(){
        Destroy(gameObject);
    }

}
