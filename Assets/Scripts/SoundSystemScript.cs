﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystemScript : MonoBehaviour
{
    public static AudioClip sampleSoundtrack, adventureSoundtrack;
    public static AudioClip sampleSound, sharkSound, swimmingSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        //SOUNDS
        //Los nombres en comillas "" son las pistas de musica en la carpeta resources(sin extension)
        sampleSound = Resources.Load<AudioClip>("Sound_sample");
        sharkSound = Resources.Load<AudioClip>("SHARK_ATACK_1");
        swimmingSound = Resources.Load<AudioClip>("SWIMMING");

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
            

        }
    }
    
   // public static void PlaySoundSwimming (string clip)
//	{
  //      switch (clip)
	//	{
    //        case "Sound_sample":
    //            audioSrc.PlayOneShot(sampleSound);
    //            break;
    //
    //        case "SWIMMING":
    //            audioSrc.PlayOneShot(swimmingSound);
    //            break;
    //    }
  //  }

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
