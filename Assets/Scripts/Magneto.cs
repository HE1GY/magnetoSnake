using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magneto : MonoBehaviour
{
    [SerializeField] private float _power=1;
    private const int MaxDistance=100;
    private const string LayerNames = "Magnetable";

    private void Update()
    {
        Vector3 rayOrg = transform.position;
        Vector3 rayDir = transform.forward;
        Ray ray = new Ray(rayOrg,rayDir);
        Debug.DrawRay(rayOrg,rayDir*MaxDistance,Color.blue);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, MaxDistance,LayerMask.GetMask(LayerNames)))
        {
            raycastHit.rigidbody.AddForce((transform.position-raycastHit.point)*_power);
        }
    }
}
