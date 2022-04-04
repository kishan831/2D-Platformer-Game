using UnityEngine;
using UnityEngine.SceneManagement;


//from Lobby To Next Level..
public class LobbyManager : MonoBehaviour
{
    public GameObject LevelLoader;
   public void playgame() {
       SoundManager.Instance.Play(SoundManager.Sound.ButtonClick);
       LevelLoader.SetActive(true);
   }
}
