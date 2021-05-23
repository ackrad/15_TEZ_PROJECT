using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Counter : MonoBehaviour
{
    public int totalCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalCount = GetComponentsInChildren<LandScript>().Length;

        
    }


  
}
