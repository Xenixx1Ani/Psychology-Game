using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAudioManager : MonoBehaviour
{
    [SerializeField]
    public AudioClip[] audios;
    public AudioSource src;

    public void playAudio(int index){
        src.clip = audios[index];
        src.Play();
    }
}
