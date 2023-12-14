using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public bool cameraMove = false;
    public GameObject menuCreateCamera;
    public GameObject menuBuild;
    public GameObject deleteAllMenu;
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
        _crearController.canBuild = true;
        _crearController.valueObject = -1;
        menuBuild.SetActive(true);
        menuCreateCamera.SetActive(false);
    }

    public void closeCreateMode()
    {
        _crearController.canBuild = false;
        _crearController.valueObject = -1;
        menuBuild.SetActive(false);
        menuCreateCamera.SetActive(true);
    }

    public void deleteObject()
    {
        if (_crearController.canDelete == false)
        {
            _crearController.canDelete = true;
        }
        else if (_crearController.canDelete == true)
        {
            _crearController.canDelete = false;
        }
    }

    public void openDeleteAllMenu()
    {
        _crearController.valueObject = -1;
        deleteAllMenu.SetActive(true);
        menuCreateCamera.SetActive(false);
    }

    public void closeDeleteAllMenu()
    {
        _crearController.valueObject = -1;
        deleteAllMenu.SetActive(false);
        menuCreateCamera.SetActive(true);
    }

    public void deleteAllTree1()
    {
        GameObject[] allTree1 = GameObject.FindGameObjectsWithTag("Arbol1");
        foreach (GameObject tree1 in allTree1)
            GameObject.Destroy(tree1);
    }

    public void deleteAllTree2()
    {
        GameObject[] allTree2 = GameObject.FindGameObjectsWithTag("Arbol2");
        foreach (GameObject tree2 in allTree2)
            GameObject.Destroy(tree2);
    }

    public void deleteAllHouse()
    {
        GameObject[] allHouse = GameObject.FindGameObjectsWithTag("Casa");
        foreach (GameObject house in allHouse)
            GameObject.Destroy(house);
    }

    public void deleteAllTemple()
    {
        GameObject[] allTemple = GameObject.FindGameObjectsWithTag("Templo");
        foreach (GameObject temple in allTemple)
            GameObject.Destroy(temple);
    }
}
