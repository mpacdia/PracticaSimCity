using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cameraMovement : MonoBehaviour
{
    public TMP_Text text;
    public GameObject Camera;
    Rigidbody rb;
    public float rotationX = 0f;
    public float rotationY = 0f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Camera = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");


        rotationX += mouseX;
        rotationY += mouseY;

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0);
    }

    void move()
    {
        Vector3 strightCamera = Camera.transform.forward;
        Vector3 sideCamera = Camera.transform.right;
        strightCamera.y = 0;
        sideCamera.y = 0;

        Vector3 direction = Input.GetAxisRaw("Horizontal") * sideCamera + Input.GetAxisRaw("Vertical") * strightCamera;
        
        direction.y = rb.velocity.y;

        Debug.Log(direction);

        rb.velocity = direction;
    }
}
