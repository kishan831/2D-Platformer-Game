using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//Implementation Of Sound In Our Game Using Singleton And Take It To The Next Scene As Well..
public class SoundManager : MonoBehaviour
{

    private static SoundManager instance;
    public static SoundManager Instance { get { return instance; }}

    public AudioSource SoundEffect;
    public AudioSource SoundMusic;

    public SoundType[] Sounds;

    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);   //GameObject Won't Derstroy When Goes TO Next Scene...
        }

        else {
            Destroy(gameObject);
        }
    }

    public void Play(Sound sound) {
        AudioClip clip = GetAudioClip(sound);
        if(clip != null) {
            SoundEffect.PlayOneShot(clip);

        }

    }

    public void MovementSound(Sound sound) {
        AudioClip clip = GetAudioClip(sound);
        if(clip != null) {
            SoundEffect.Play();
        }

    }

    //Getting Up Audio Clip

    private AudioClip GetAudioClip(Sound sound) {

        SoundType item = Array.Find(Sounds , i => i.soundtype == sound);
        if(item != null) {
            return item.soundclip;
        }
        return null;

    }
  

[Serializable] 
 public class SoundType {
    public Sound soundtype;
    public AudioClip soundclip;
 }  

 public enum Sound {
    ButtonClick,
    PlayerMovement
 }



}
