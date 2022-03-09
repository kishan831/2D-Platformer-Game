using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletionMessage : MonoBehaviour
{
    //On Colliding With The CheckPoint
    private void OnTriggerEnter2D(Collider2D Collision) {
        if(Collision.gameObject.GetComponent<Player>() != null) {
            Debug.Log("Player Has Reached Check point");
        }
    }
}
