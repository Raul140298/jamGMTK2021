﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystemScript : MonoBehaviour
{
    public static AudioClip sampleSoundtrack, adventureSoundtrack;
    public static AudioClip sampleSound, sharkSound, swimmingSound, loseSound, winSound, winSound2, biteSound, lightSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        //SOUNDS
        //Los nombres en comillas "" son las pistas de musica en la carpeta resources(sin extension)
        sampleSound = Resources.Load<AudioClip>("Sound_sample");
        sharkSound = Resources.Load<AudioClip>("SHARK_ATACK_1");
        swimmingSound = Resources.Load<AudioClip>("SWIMMING");
        loseSound = Resources.Load<AudioClip>("POP_NEGATIVE_1");
        winSound = Resources.Load<AudioClip>("SPECIAL_COLECT_3");
        winSound2 = Resources.Load<AudioClip>("POP_POSITIVE_5");
        biteSound = Resources.Load<AudioClip>("Bite");
        lightSound = Resources.Load<AudioClip>("POP_4");

        //SOUNDTRACKS
        //Los nombres en comillas "" son las pistas de musica en la carpeta resources(sin extension)
        sampleSoundtrack = Resources.Load<AudioClip>("Soundtrack_sample");
        adventureSoundtrack = Resources.Load<AudioClip>("Water-adventure");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound (string clip)
	{
        switch (clip)
		{
            case "Sound_sample":
                audioSrc.PlayOneShot(sampleSound);
                break;

            case "SHARK_ATACK_1":
                audioSrc.PlayOneShot(sharkSound);
                break; 

            case "POP_NEGATIVE_1":
                audioSrc.PlayOneShot(loseSound);
                break; 

            case "POP_POSITIVE_5":
                audioSrc.PlayOneShot(winSound2);
                break;
            
            case "SPECIAL_COLECT_3":
                audioSrc.PlayOneShot(winSound);
                break;
            
            case "Bite":
                audioSrc.PlayOneShot(biteSound);
                break;
            
            case "POP_4":
                audioSrc.PlayOneShot(lightSound);
                break;
        }
    }

    public static void PlaySoundtrack(string clip2)
    {
        audioSrc.loop = true;
        audioSrc.Stop();
        
        switch (clip2)
        {
            case "Soundtrack_sample":              
                audioSrc.clip = sampleSoundtrack;   
                break;
            case "Water-adventure":
                audioSrc.clip = adventureSoundtrack;
                break;
        }

        audioSrc.Play();
    }



    public static void Stop()
    {
        audioSrc.Stop();
    }
}
