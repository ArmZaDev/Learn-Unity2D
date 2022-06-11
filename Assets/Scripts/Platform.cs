using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    int valueToSend = 9;

    // Start is called before the first frame update
    void Start()
    {
        string stringfromOutSide = FindObjectOfType<Cube>().PritingfromOutside(valueToSend);
        Debug.Log(stringfromOutSide);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
