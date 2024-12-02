using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MonkeyMoves : MonoBehaviour
{
    public AudioClip[] primateSounds;
    public AudioSource primateSource;

    private int selectPrimate;
    private float primatePitch;
    private float timer;
    private float timerInterval;

    void Start(){
        primatePitch = Random.Range(0.5f,1.5f);
        selectPrimate = Random.Range(0, primateSounds.Length);
        timerInterval = Random.Range(2.5f,5f);
    }

    void Update(){
        timer += Time.deltaTime;

        if(timer > timerInterval){
            //play sound
            primateSource.clip = primateSounds[selectPrimate];
            primateSource.pitch = primatePitch;
            primateSource.Play();
            //recalculate
            timer = 0;
            primatePitch = Random.Range(0.5f,1.5f);
            selectPrimate = Random.Range(0, primateSounds.Length);
            timerInterval = Random.Range(2.5f,5f);
        }
    }
}
