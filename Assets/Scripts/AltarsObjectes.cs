using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AltarsObjectes : MonoBehaviour
{
    [SerializeField]
    GameObject altar1;
    [SerializeField]
    GameObject altar2;
    [SerializeField]
    GameObject altar3;

    ObjecteCorrecte estaActiu1;
    ObjecteCorrecte estaActiu2;
    ObjecteCorrecte estaActiu3;

    public UnityEvent activacio_orbe_objectes;


    void Awake()
    {
        estaActiu1 = altar1.GetComponent<ObjecteCorrecte>();
        estaActiu2 = altar2.GetComponent<ObjecteCorrecte>();
        estaActiu3 = altar3.GetComponent<ObjecteCorrecte>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estaActiu1.altar_actiu && estaActiu2.altar_actiu && estaActiu3.altar_actiu)
        {
            //Debug.Log("ALTARS PRINCIPALS ACTIVATS");
            activacio_orbe_objectes.Invoke();
        }
    }
}
