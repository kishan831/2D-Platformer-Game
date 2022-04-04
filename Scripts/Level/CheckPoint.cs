using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    //On Colliding With The CheckPoint Player Reached Finish point..
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.gameObject.GetComponent<PlayerController>() != null) {
            Debug.Log("You Have Completed The Level");
            LevelManager.Instance.MarkCurrentLevelComplete();
        }
    }
}
