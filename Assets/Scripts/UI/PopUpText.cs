using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpText : MonoBehaviour
{
    [SerializeField] private Magneto _magneto;
    [SerializeField] private Text _text;


    private void OnEnable()
    {
        _magneto.CanCatch += OnCanCatch;
    }

    private void OnDisable()
    {
        _magneto.CanCatch -= OnCanCatch;
    }


    private void OnCanCatch(bool canCatch, Vector3 position, Rigidbody rigidbody)
    {
        _text.enabled = canCatch;
    }
}
