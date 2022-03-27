using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandScope : MonoBehaviour
{
    private const int TurnSpeed = 2;
    public bool IsRotateting;
    void Update()
    {
        if (IsRotateting)
        {
            transform.Rotate(Vector3.forward*TurnSpeed);
        }
    }
}
