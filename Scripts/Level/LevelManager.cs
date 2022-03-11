using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

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

        //unlock Next Level
       /* int NextSceneIndex = Currentscene.buildIndex + 1;
        Scene nextScene = SceneManager.GetSceneByBuildIndex(NextSceneIndex);
        SetLevelStatus(nextScene.name,LevelStatus.Unlocked);*/

        int CurrentsceneIndex = Array.FindIndex(Levels, level=> level == Currentscene.name);
        int nextScene = CurrentsceneIndex + 1;
        if(nextScene < Levels.Length)
        {
            SetLevelStatus(Levels[nextScene],LevelStatus.Unlocked);
        }



    }

    public LevelStatus GetLevelStatus(string Level) {
        LevelStatus levelStatus = (LevelStatus) PlayerPrefs.GetInt(Level,0);
        return levelStatus;

    }

    public void SetLevelStatus(string Level, LevelStatus levelStatus) {
        PlayerPrefs.SetInt(Level, (int)levelStatus);
        Debug.Log("SettingLevel:" + Level + "Status :" + levelStatus );
    }

 
}