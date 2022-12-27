using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;

    public Rigidbody2D rb;
    public Camera cam;

    public LayerMask solidLayer;
    public LayerMask grassLayer;

    private bool isMoving;
    public Transform movePoint;

    Vector2 movement;
    Vector2 mousePos;

    private void Start() {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Is Walkable: " + isWalkable());
        if(isWalkable()){
            transform.position = Vector3.MoveTowards(transform.position,movePoint.position, moveSpeed * Time.deltaTime);    

        }
        else{
            movePoint.position = transform.position;
        }

        if(Vector3.Distance(transform.position, movePoint.position) <= .05f){
            
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f){
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                CheckForEncounters();
            }
            if(Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f){
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                CheckForEncounters();
            }
        }

        cam.transform.position = new Vector3(transform.position.x, transform.position.y, -16);
       
    }


    private bool isWalkable(){
        if(Physics2D.OverlapCircle(movePoint.position, 0.3f, solidLayer) != null){
            return false;
        }
        return true;
    }

    private void CheckForEncounters(){
        if(Physics2D.OverlapCircle(transform.position, 0.3f, grassLayer) != null){
            if(Random.Range(1,101) < 10){
                Debug.Log("Encounter!");
            }
        }
    }
}
