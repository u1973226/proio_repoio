using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TemplePedra : MonoBehaviour
{
    [SerializeField]
    GameObject placa1;
    [SerializeField]
    GameObject placa2;

    Plaques_TP estaActiva1;
    Plaques_TP estaActiva2;
    
    public UnityEvent activacio_orbe_pedra;
    public bool notOpen = false;


    void Awake()
    {
        estaActiva1 = placa1.GetComponent<Plaques_TP>();
        estaActiva2 = placa2.GetComponent<Plaques_TP>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estaActiva1.activada && estaActiva2.activada && notOpen)
        {
            //Debug.Log("ALTAR TEMPLE PEDRA ACTIVAT");
            activacio_orbe_pedra.Invoke();
            notOpen = true;
        }
    }
}
