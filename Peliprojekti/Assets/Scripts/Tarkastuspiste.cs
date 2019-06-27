using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarkastuspiste : MonoBehaviour
{
    public GameObject Checkpoint;
    public GameObject Player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.5f);
        Player.transform.position = new Vector2(Checkpoint.transform.position.x, Checkpoint.transform.position.y);
    }
}
