using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed;
    public float panningSpeed;
    bool holdingMiddleMouse = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MiddleMouseDrag();

        if(!holdingMiddleMouse)
            this.transform.position += new Vector3(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
    }

    void MiddleMouseDrag()
    {
        if (Input.GetKey(KeyCode.Mouse2))
        {
            holdingMiddleMouse = true;

            this.transform.position += new Vector3(-Input.GetAxis("Mouse X") * panningSpeed * Time.deltaTime, 0f, -Input.GetAxis("Mouse Y") * panningSpeed * Time.deltaTime);
        }
        else
        {
            holdingMiddleMouse = false;
        }
    }
}
