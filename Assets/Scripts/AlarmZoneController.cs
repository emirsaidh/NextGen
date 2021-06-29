using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AlarmZoneController : MonoBehaviour
{
    //public static AudioClip alarmSound;
    AudioSource alarmSound;

    private void Start()
    {
        alarmSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "robotSphere") //otherwise OnTriggerEnter works 1 time on the start
        {                                           //i could not solve it(collides with "default" named object)
            alarmSound.Play(0);
            alarmSound.loop = true;
        }
        //Debug.Log("Enter " + other.gameObject.name);


    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exit");
        alarmSound.Pause();
    }


}
