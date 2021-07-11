using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    protected void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
        Debug.Log("Coin triggered");
        Destroy(gameObject);

    }

}
