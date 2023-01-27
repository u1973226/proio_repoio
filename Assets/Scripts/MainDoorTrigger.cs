using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainDoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject placa1;
    [SerializeField]
    GameObject placa2;
    [SerializeField]
    GameObject placa3;
    [SerializeField]
    GameObject placa4;
    [SerializeField]
    GameObject porta;

    EsActiva estaActiva1;
    EsActiva estaActiva2;
    EsActiva estaActiva3;
    EsActiva estaActiva4;

    bool isOpened = false;

    public UnityEvent obertura;


    void Awake()
    {
        estaActiva1 = placa1.GetComponent<EsActiva>();
        estaActiva2 = placa2.GetComponent<EsActiva>();
        estaActiva3 = placa3.GetComponent<EsActiva>();
        estaActiva4 = placa4.GetComponent<EsActiva>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estaActiva1.activada && estaActiva2.activada && estaActiva3.activada && estaActiva4.activada && isOpened == false)
        {
            //Debug.Log("PORTA PRINCIPAL ACTIVADA");
            obertura.Invoke();
            isOpened = true;
        }
    }
}
