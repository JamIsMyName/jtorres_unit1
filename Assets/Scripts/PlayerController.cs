using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // rate of forward backward movement
    public float speed = 15.0f;
    public float turnSpeed = 15.0f;

    public float horizontalInput;
    public float vertivcalInput;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       vertivcalInput = Input.GetAxis("Vertical"); 

       horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertivcalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }

}






