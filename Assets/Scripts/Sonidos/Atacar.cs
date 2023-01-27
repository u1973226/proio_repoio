using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    public AudioSource attackSound;

    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            attackSound.enabled = true;
        }
        else {
            attackSound.enabled = false;
        }
    }
}
