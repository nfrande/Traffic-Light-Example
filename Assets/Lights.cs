using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    
    [SerializeField] GameObject greenLight, yellowLight, redLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
float counter = Time.time % 10;
     
     if (counter > 0 && counter < 3)
     {
     greenLight.GetComponent<Renderer>().material.color = Color.green;
     yellowLight.GetComponent<Renderer>().material.color = Color.gray;
     redLight.GetComponent<Renderer>().material.color = Color.gray;
     }
     if (counter > 3 && counter < 5)
     {
     greenLight.GetComponent<Renderer>().material.color = Color.gray;
     yellowLight.GetComponent<Renderer>().material.color = Color.yellow;
     redLight.GetComponent<Renderer>().material.color = Color.gray;
     }
     if (counter > 5 && counter < 7)
     {
     greenLight.GetComponent<Renderer>().material.color = Color.gray;
     yellowLight.GetComponent<Renderer>().material.color = Color.gray;
     redLight.GetComponent<Renderer>().material.color = Color.red;
     }
     if (counter > 7 && counter < 9)
     {
     greenLight.GetComponent<Renderer>().material.color = Color.gray;
     yellowLight.GetComponent<Renderer>().material.color = Color.yellow;
     redLight.GetComponent<Renderer>().material.color = Color.red;
     }
    }
}
