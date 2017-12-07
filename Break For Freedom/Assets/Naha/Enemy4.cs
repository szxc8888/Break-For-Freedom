using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Enemy4 : MonoBehaviour
{

    // Enemy4の当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
      //  if (other.gameObject.tag == "Player")   // 囚人服の場合(デフォルト)
      //  {
      //      SceneManager.LoadScene("Enemy");    // Enemy1,2,3,4に触れたらGAMEOVER
      //  }
      //  if (other.gameObject.tag == "wear1")    // 看守服の場合
      //  {
      //      SceneManager.LoadScene("Enemy");    // Enemy2,3,4に触れたらGAMEOVER
      //  }
      //  if (other.gameObject.tag == "wear2")    // 〇〇の場合
      // {
      //      SceneManager.LoadScene("Enemy");    // Enemy3,4に触れたらGAMEOVER
      //  }
        if (other.gameObject.tag == "wear3")    // 〇〇の場合
        {
            SceneManager.LoadScene("Enemy");    // Enemy4に触れたらGAMEOVER
        }
    }
}



