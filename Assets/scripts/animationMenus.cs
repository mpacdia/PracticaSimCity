using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationMenus : MonoBehaviour
{
    private void appearAnimation()
    {
        LeanTween.scale(this.gameObject, new Vector3(5f, 5f, 5f), 1.5f).setEaseInOutSine();
    }

    void Start()
    {
        LeanTween.init(10000);
        appearAnimation();
    }
}
