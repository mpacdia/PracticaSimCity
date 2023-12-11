using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public bool cameraMove = false;
    public GameObject menuCreateCamera;
    public GameObject menuBuild;
    createObjects _crearController;

    void Start()
    {
        _crearController = GameObject.Find("MainCamera").GetComponent<createObjects>();
    }

    public void activateCamera()
    {
        if (cameraMove)
        {
            cameraMove = false;
        }
        else
        {
            cameraMove = true;
        }
    }

    public void chooseArbol1()
    {
        _crearController.valueObject = 0;
    }

    public void chooseArbol2()
    {
        _crearController.valueObject = 1;
    }

    public void chooseCasa()
    {
        _crearController.valueObject = 2;
    }

    public void chooseTemplo()
    {
        _crearController.valueObject = 3;
    }

    public void createMode()
    {
        menuBuild.SetActive(true);
        menuCreateCamera.SetActive(false);
    }

    public void closeCreateMode()
    {
        menuBuild.SetActive(false);
        menuCreateCamera.SetActive(true);
    }
}
