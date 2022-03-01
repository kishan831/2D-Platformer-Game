using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPetrol : MonoBehaviour
{
    // Start is called before the first frame update

     public bool MustPetrol;
     private bool mustTurn;

     public float WalkSpeed;

     public LayerMask groundlayer;

     public Transform groundcheckpos;

     public Rigidbody2D rb;

     public Collider2D col;

    void Start()
    {
        MustPetrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(MustPetrol) {
            petrol();
        }
    }
    
    private void FixedUpdate() {
        if(MustPetrol) {
          mustTurn = !Physics2D.OverlapCircle(groundcheckpos.position,.1f,groundlayer);
        }
    }

    void petrol() {
       if(mustTurn || col.IsTouchingLayers(groundlayer)) {
          flip();
       }

       rb.velocity = new Vector2(WalkSpeed * Time.deltaTime, rb.velocity.y);
    }

    void flip() {
        MustPetrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1,transform.localScale.y);
        WalkSpeed *= -1;
        MustPetrol = true;
    }
}
