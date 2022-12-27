using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEncounters : MonoBehaviour
{
    public LayerMask playerLayer;
 
    private void Update() {
        if(Physics2D.OverlapCircle(transform.position, 0.3f, playerLayer) != null){
            Debug.Log("asdasd");
        }
    }
}
