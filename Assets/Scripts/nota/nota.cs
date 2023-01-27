using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nota : MonoBehaviour
{
    [SerializeField]
    private Image _note;

    
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            _note.enabled = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            _note.enabled = false;
        }
    }
}
