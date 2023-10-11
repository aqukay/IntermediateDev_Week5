using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource Gate;
    public AudioSource Beep;
    public AudioSource Grass;
    public AudioSource Ambiance;
    public AudioSource Ambiance2;

    public void PlayGate()
    {
        Gate.Play();
    }

    public void PlayBeep()
    {
        Beep.Play();
    }

    public void PlayGrass()
    {
        Grass.Play();
    }

    public void PlayAmbiance()
    {
        Ambiance.Play();
    }

    public void PlayAmbiance2()
    {
        Ambiance2.Play();
    }
}
