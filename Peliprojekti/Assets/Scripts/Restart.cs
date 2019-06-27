﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Pelaaja putosi kuolemaansa.");
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}

