using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOB : MonoBehaviour
{
    public float bob_length; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,transform.forward*bob_length,Color.red);
    }
}
