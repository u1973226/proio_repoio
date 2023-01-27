using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaNit : MonoBehaviour
{
    public int rotationScale = 10;
    Transform llum;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    // Start is called before the first frame update
    void Start()
    {
        llum = GameObject.FindGameObjectWithTag("DirectionalLight").transform;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationScale*Time.deltaTime, 0 , 0);
        
        if (llum.transform.localRotation.eulerAngles.x < 100)
        {
            enemy1.SetActive(false);
            enemy2.SetActive(false);
            enemy3.SetActive(false);
            enemy4.SetActive(false);
        }
        else 
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
        }
        
    }
}