using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletionMessage : MonoBehaviour
{
    //On Colliding With The CheckPoint
    private void OnTriggerEnter2D(Collider2D Collision) {
        if(Collision.gameObject.GetComponent<Player>() != null) {
            Debug.Log("You Have Completed The Level");
            LevelManager.Instance.MarkCurrentLevelComplete();
        }
    }
}
