using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorActiu : MonoBehaviour
{
    [SerializeField]
    GameObject activador;

    public bool actiu = false;

    void OnTriggerStay(Collider col)
    {
        Debug.Log("ACTIVADOR activat");
        actiu = true;
    }

    void OnTriggerExit(Collider col)
    {
        actiu = false;
    }
}
