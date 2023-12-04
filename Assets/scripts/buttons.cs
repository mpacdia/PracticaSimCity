using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public bool cameraMove = false;


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
        createObjects.valueObject = 0;
    }

    public void chooseArbol2()
    {
        createObjects.valueObject = 1;
    }

    public void chooseCasa()
    {
        createObjects.valueObject = 2;
    }

    public void chooseTemplo()
    {
        createObjects.valueObject = 3;
    }
}
