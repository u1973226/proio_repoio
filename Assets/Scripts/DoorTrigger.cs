using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject comporta;
    [SerializeField]
    GameObject placa;

    //SONS ANIMACIONS
    public AudioSource soPlaca;
    public AudioSource soPorta;
 
    //TRIGGERS ANIMACIONS
    //EVENTS PLACA
    public UnityEvent activacio;
    public UnityEvent semi_activacio;
    public UnityEvent desactivacio;
    //EVENTS PORTA
    public UnityEvent obertura;
    public UnityEvent tancament;

    bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        semi_activacio.Invoke();
    }

    void OnTriggerStay(Collider col)
    {
        activacio.Invoke();
        if(isOpened == false)
        {
            obertura.Invoke();
            isOpened = true;
        }     
    }

    void OnTriggerExit(Collider col)
    {
        isOpened = false;
        tancament.Invoke();
        desactivacio.Invoke();
    }
}
