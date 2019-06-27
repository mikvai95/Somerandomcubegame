using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public int tasoNum;
    public bool viimeinenTaso;
    public GameObject pelaaUudestaanNappi;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Taso läpäisty!");
        }
        if (viimeinenTaso)
        {
            pelaaUudestaanNappi.SetActive(true);
        }
        else
        {
            StartCoroutine("jumpToNextLevel");
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene("level1");
        
    }
    IEnumerator jumpToNextLevel()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("level" + tasoNum);
    }
    
}
