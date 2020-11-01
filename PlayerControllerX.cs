using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 50.0f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
    //Move forward
    transform.Translate(Vector3.forward * Time.deltaTime * speed);

     // get the user's vertical input
     verticalInput = Input.GetAxis("Vertical");

      //Tilt plane based on up/down arrows
     transform.Rotate(Vector3.left, Time.deltaTime * rotationSpeed * verticalInput);

     }
}
