using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color Color;
    public Camera cam;
   
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color;
      
    }

    private void OnMouseDown()
    {
       cam.GetComponent<Camera>().backgroundColor = Color;
    }

}
