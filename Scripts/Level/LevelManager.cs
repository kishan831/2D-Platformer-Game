using UnityEngine;

public class LevelManager : MonoBehaviour {
    public static LevelManager Instance { get {return instance;}}

    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }
    }

    public LevelStatus GetLevelStatus(string Level) {
        LevelStatus levelStatus = (levelStatus) PlayerPrefs.GetInt(Level,0);

    }

    public void SetLevelStatus(string Level, LevelStatus levelStatus) {
        PlayerPrefs.SetInt(Level, (int)LevelStatus);
    }

 
}