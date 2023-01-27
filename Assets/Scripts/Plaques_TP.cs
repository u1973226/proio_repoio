using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Plaques_TP : MonoBehaviour
{
    [SerializeField]
    GameObject placa;
    [SerializeField]
    GameObject activador;

    public bool activada = false;

    //EVENTS PLACA
    public UnityEvent activacio_TP;
    public UnityEvent semi_activacio_TP;
    public UnityEvent desactivacio_TP;

    void OnTriggerEnter(Collider col)
    {
        semi_activacio_TP.Invoke();
    }

    void OnTriggerStay(Collider col)
    {
        if(col.gameObject.name == activador.gameObject.name) {
            activada = true;
            activacio_TP.Invoke();
        }
        
    }

    void OnTriggerExit(Collider col)
    {
        activada = false;
        desactivacio_TP.Invoke();
    }
}
