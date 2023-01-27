using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjecteCorrecte : MonoBehaviour
{
    [SerializeField]
    GameObject altar;
    [SerializeField]
    GameObject objecte;

    public bool altar_actiu = false;

    //EVENTS ALTAR
    public UnityEvent activacio_altar;

    void OnTriggerStay(Collider col)
    {
        //Debug.Log("Altar activat per " + col.gameObject.name);
        //Debug.Log("Hauria d'estar activat per " + objecte.gameObject.name);
        //Debug.Log("Hi ha algo al altar");
        if(col.gameObject.name == objecte.gameObject.name) {
            //Debug.Log("Altar activat per " + col.gameObject.name);
            activacio_altar.Invoke();
            altar_actiu = true;
            
        }
    }
}
