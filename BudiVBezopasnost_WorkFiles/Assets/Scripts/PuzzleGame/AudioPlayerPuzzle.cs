using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerPuzzle : MonoBehaviour
{
    public AudioSource peshehodna;
    public AudioSource stop;
    public AudioSource deca;
    public AudioSource vnimanie;
    public AudioSource hora;
    public AudioSource svetofar;
    public void ClickSoundPeshehodna()
    {
        peshehodna.Play();
    }
    public void ClickSoundStop()
    {
        stop.Play();
    }
    public void ClickSoundDeca()
    {
        deca.Play();
    }
    public void ClickSoundVnimanie()
    {
        vnimanie.Play();
    }
    public void ClickSoundHora()
    {
        hora.Play();
    }
    public void ClickSoundSvetofar()
    {
        svetofar.Play();
    }
}
