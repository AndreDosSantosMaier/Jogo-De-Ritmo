using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodar : MonoBehaviour
{
    public GameObject anchor;
    public float speed = 50f;
    Vector3 axis = new Vector3(0,0,1);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(anchor.transform.position, axis ,speed*Time.deltaTime);
    }
}
