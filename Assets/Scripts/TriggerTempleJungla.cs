using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerTempleJungla : MonoBehaviour
{
    [SerializeField]
    GameObject activador1;
    [SerializeField]
    GameObject activador2;

    ActivadorActiu estaActiu1;
    ActivadorActiu estaActiu2;

    bool orbeJungla = false;

    public UnityEvent spawn_orbe;


    void Awake()
    {
        estaActiu1 = activador1.GetComponent<ActivadorActiu>();
        estaActiu2 = activador2.GetComponent<ActivadorActiu>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estaActiu1.actiu && estaActiu2.actiu && orbeJungla == false)
        {
            Debug.Log("ORBE JUNGLA ACTIVAT");
            spawn_orbe.Invoke();
            orbeJungla = true;
        }
    }
}
