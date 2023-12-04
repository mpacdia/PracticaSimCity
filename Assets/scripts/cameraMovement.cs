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

    buttons controller;


    void Start()
    {
        controller = GameObject.Find("controllerButtons").GetComponent<buttons>();

        rb = GetComponent<Rigidbody>();
        Camera = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.cameraMove)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");


            rotationX += mouseX;
            rotationY += mouseY;

            transform.eulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
    }
}
