using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 [RequireComponent(typeof(Button))]

 public class LevelLoader : MonoBehaviour
{
    private Button button;

    public string LevelName;

    private void Awake() {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);

    }

    private void onClick() {
        LevelStatus levelStatus = LevelManager.Instance.GetLevelStatus(LevelName);
        
        switch(LevelName) {
            case levelStatus.Locked :
            break;

            case levelStatus.UnLocked :
            SceneManager.LoadScene(LevelName);
            break;

            case levelStatus.Completed :
            SceneManager.LoadScene(LevelName);
            break;


        }
    }

}