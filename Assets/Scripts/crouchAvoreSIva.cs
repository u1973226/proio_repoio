using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouchAvoreSIva : MonoBehaviour
{
    public KeyCode key = KeyCode.LeftControl;
    public CharacterController PlayerHeight;
    public float normalHeight, crouchHeight;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(key)) {
            PlayerHeight.height = crouchHeight;
            
        }
        else {
            PlayerHeight.height = normalHeight;
        }
    }
}
