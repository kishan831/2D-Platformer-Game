using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Controlling Keys...
public class KeyController : MonoBehaviour
{
    //When Player Collected The Key It Will Get Destroyed And Player Will get Inc. In Score.. 
         private void OnTriggerEnter2D(Collider2D collider2D) {
             
          if(collider2D.gameObject.GetComponent<PlayerController>() != null) {
            PlayerController player = collider2D.gameObject.GetComponent<PlayerController>();
            player.Collectibles();
            Destroy(gameObject);
        }
    }
}
