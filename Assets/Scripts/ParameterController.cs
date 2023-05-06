using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterController : MonoBehaviour
{
    StudioEventEmitter emitter;
    bool introducingTrack = true;
    float nextTrackValue = 1.0f;
    public float param;
    // Start is called before the first frame update
    void Start()
    {
        emitter = GetComponent<StudioEventEmitter>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (introducingTrack)
        {
            emitter.EventInstance.getParameterByName("Tracks", out float value);
            value += Time.deltaTime;
            if(value < nextTrackValue)
                emitter.EventInstance.setParameterByName("Tracks", value);
            else
            {
                emitter.EventInstance.setParameterByName("Tracks", nextTrackValue);
                introducingTrack = false;
            }
        }
        emitter.EventInstance.getParameterByName("Tracks", out param);
    }

    public void PlayNextTrack(float value)
    {
        introducingTrack = true;
        nextTrackValue = value;
    }
}
