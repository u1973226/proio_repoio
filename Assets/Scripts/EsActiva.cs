using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EsActiva : MonoBehaviour
{
    [SerializeField]
    GameObject placa;

    public bool activada = false;

    //EVENTS PLACA
    public UnityEvent activacio;
    public UnityEvent semi_activacio;
    public UnityEvent desactivacio;

    void OnTriggerEnter(Collider col)
    {
        semi_activacio.Invoke();
    }

    void OnTriggerStay(Collider col)
    {
        //Debug.Log("Placa activada");
        activada = true;
        activacio.Invoke();
    }

    void OnTriggerExit(Collider col)
    {
        activada = false;
        desactivacio.Invoke();
    }
}
