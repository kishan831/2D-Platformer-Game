using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScripts : MonoBehaviour
{
    public GameObject LevelLoader;
   public void playgame() {
       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       LevelLoader.SetActive(true);
   }
}
