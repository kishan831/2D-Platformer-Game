using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScripts : MonoBehaviour
{
    public GameObject LevelLoader;
   public void playgame() {
       SoundManager.Instance.Play(SoundManager.Sound.ButtonClick);
       LevelLoader.SetActive(true);
   }
}
