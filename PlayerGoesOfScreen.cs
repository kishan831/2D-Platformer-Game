using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoesOfScreen : MonoBehaviour
{
      private void OnTriggerEnter2D(Collider2D collider2d) {
        if(Collision.gameObject.GetComponent<Player>() != null) {
            Debug.Log("Player Died");
        }
    }
}
