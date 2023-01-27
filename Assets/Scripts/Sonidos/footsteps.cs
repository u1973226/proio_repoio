using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepSound, sprintFootstepSound;

    void Update() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)) {
            if (Input.GetKey(KeyCode.LeftShift)) {
                sprintFootstepSound.enabled = true;
                footstepSound.enabled = false;
            }
            else {
                sprintFootstepSound.enabled = false;
                footstepSound.enabled = true;
            }
        }
        else {
            sprintFootstepSound.enabled = false;
            footstepSound.enabled = false;
        }
    }
    
}
