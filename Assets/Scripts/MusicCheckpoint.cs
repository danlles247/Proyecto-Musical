using HeneGames.Airplane;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MusicCheckpoint : MonoBehaviour
{
    ParameterController controller;
    [SerializeField]
    float instrumentValue;

    private void Start()
    {
        controller = transform.parent.GetComponent<ParameterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<SimpleAirPlaneController>())
        {
            controller.PlayNextTrack(instrumentValue);
        }
    }
}
