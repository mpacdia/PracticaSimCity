using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationMenu2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        appearAnimation();
    }

    private void appearAnimation()
    {
        LeanTween.move(this.gameObject, new Vector3(250f, 250f, 0f), 2f).setEaseInOutSine();
    }

}
