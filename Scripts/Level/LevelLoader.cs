using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 [RequireComponent(typeof(Button))]

 public class LevelLoader : MonoBehaviour
{

    //Button Lead to NextScene
    private Button LevelLoadbutton;

    public string LevelName;

    private void Awake() {
        LevelLoadbutton = GetComponent<Button>();
        LevelLoadbutton.onClick.AddListener(NextSceneBtn);

    }

    //First Scene Is Unlocked And Then It Will Unlocked When Player Finishes Every Level.. 

    private void  NextSceneBtn() {
        LevelStatus levelStatus = LevelManager.Instance.GetLevelStatus(LevelName);
        
        switch(levelStatus) {

            case LevelStatus.Locked:
            break;

            case LevelStatus.Unlocked :
            SoundManager.Instance.Play(SoundManager.Sound.ButtonClick);
            SceneManager.LoadScene(LevelName);
            break;

            case LevelStatus.Completed :
             SoundManager.Instance.Play(SoundManager.Sound.ButtonClick);
            SceneManager.LoadScene(LevelName);
            break;


        }
    }

}