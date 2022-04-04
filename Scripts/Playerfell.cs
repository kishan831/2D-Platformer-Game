using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfell : MonoBehaviour
{
     //Player Goes Outside Of The Scene dies too  
      private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.gameObject.GetComponent<PlayerController>() != null) {
            Debug.Log("Player Died");
        }
    }
}
