using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObjects : MonoBehaviour
{
    public GameObject arbol1;
    public GameObject arbol2;
    public GameObject casa;
    public GameObject templo;
    GameObject toBuild;
    public int valueObject { get; set; }
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        valueObject = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit objectPosition;

        Debug.Log(valueObject);

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(cameraRay, out objectPosition, Mathf.Infinity))
            {
                if (objectPosition.collider.gameObject.CompareTag("terrain"))
                {
                    chooseObject();
                    Debug.Log(toBuild.name);
                    Object.Instantiate(toBuild, objectPosition.point, new Quaternion(0, 0, 0, 0));
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawRay(transform.position, transform.forward);
    }

    public void chooseObject()
    {
        if (valueObject == 0)
        {
            toBuild = arbol1;
        }
        else if (valueObject == 1)
        {
            toBuild = arbol2;
        }
        else if (valueObject == 2)
        {
            toBuild = casa;
        }
        else if (valueObject == 3)
        {
            toBuild = templo;
        }
    }

    
}
