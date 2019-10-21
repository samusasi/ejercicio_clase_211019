using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movSpeed = 4F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")!=0)
        {
            transform.Translate(transform.right * movSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * movSpeed * Time.deltaTime);
        }
    }
}
