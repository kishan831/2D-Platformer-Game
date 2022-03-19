using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScripts : MonoBehaviour
{
   public void playgame() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
