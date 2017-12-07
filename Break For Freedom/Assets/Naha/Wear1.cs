using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wear1 : MonoBehaviour
{
    //生成するゲームオブジェクト
    GameObject player, wear1, wear2, key1;
    public Sprite moguraImage;
    void Start()
    {
        this.player = GameObject.Find("Player");
        this.wear1 = GameObject.Find("wear1");
       this.wear2 = GameObject.Find("wear2");
       this.key1 = GameObject.Find("key1");
    }


    // Enemy1に当たり判定なし
    void OnTriggerEnter2D(Collider2D other)
    {

         // key1に触れたら回収
        if (other.gameObject.tag == "key1")
        {

            // this.tag = "Door1";                // タグを変更する
            //  SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            //  renderer.sprite = moguraImage;     // 画像変更枠追加

            Destroy(key1);      // Wear1削除
            //   wear1.SetActive(true);
        }

        // Dooor1に触れたら回収
        if (other.gameObject.tag == "Door1")
        {
            
				
				
            // this.tag = "Door1";                // タグを変更する
            //  SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            //  renderer.sprite = moguraImage;     // 画像変更枠追加

           // SceneManager.LoadScene("Enemy");     // Wear1削除
            //   wear1.SetActive(true);
        }
    }
}

