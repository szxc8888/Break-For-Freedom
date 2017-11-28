using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Enemy1 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Enemy");
        }
    }

}

