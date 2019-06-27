using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRemove : MonoBehaviour
{
    public GameObject Gate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boss")
        {
            Debug.Log("Pomovastus päihitetty!");
            Destroy(Gate);
            
        }
    }
}