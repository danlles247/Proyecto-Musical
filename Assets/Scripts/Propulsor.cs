using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HeneGames.Airplane;

public class Propulsor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Plane")) return;

        SimpleAirPlaneController controller = other.gameObject.GetComponentInParent<SimpleAirPlaneController>();

        controller.Turbo();

        GetComponentInChildren<ParticleSystem>().Stop();
    }

}
