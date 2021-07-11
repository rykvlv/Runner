using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected void Update()
    {
        Rotate();
    }

    protected void Rotate()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f), Space.World);
    }


}