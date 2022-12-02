using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    Transform iniPos;

    void Start()
    {

        iniPos = transform;
    }


    void Update()
    {
        transform.localPosition = iniPos.localPosition;
        transform.localRotation = iniPos.localRotation;
    }
}
