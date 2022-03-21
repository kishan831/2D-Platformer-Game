using UnityEngine;
using System;
using UnityEngine.SceneManagement;


//Controlling Levels....
public class LevelManager : MonoBehaviour {

    //Here We Are Using Sinleton To carries Forward data To The Next Scene.. 

    private static LevelManager instance;
    public static LevelManager Instance { get { return instance; }}

    public string LevelOne;

    public string[] Levels;

    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }
    }

    private void Start() {
       if (GetLevelStatus(Levels[0]) == LevelStatus.Locked) {
           SetLevelStatus(Levels[0], LevelStatus.Unlocked);
       }
    }


    public void MarkCurrentLevelComplete() {

        // set Levelstatus is Complete
        Scene Currentscene =  SceneManager.GetActiveScene();
        SetLevelStatus(Currentscene.name, LevelStatus.Completed);

        int CurrentsceneIndex = Array.FindIndex(Levels, level=> level == Currentscene.name);
        int nextScene = CurrentsceneIndex + 1;

          if(nextScene < Levels.Length) {
            SetLevelStatus(Levels[nextScene],LevelStatus.Unlocked);
        }

    }

    //Getting Levels Status

    public LevelStatus GetLevelStatus(string Level) {
        LevelStatus levelStatus = (LevelStatus) PlayerPrefs.GetInt(Level,0);
        return levelStatus;

    }

    //Setting Up The Current Level 

    public void SetLevelStatus(string Level, LevelStatus levelStatus) {
        
        PlayerPrefs.SetInt(Level, (int)levelStatus);
        Debug.Log("SettingLevel:" + Level + "Status :" + levelStatus );
    }

 
}