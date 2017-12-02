using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wear2 : MonoBehaviour
{
    //生成するゲームオブジェクト
    GameObject player, wear1, wear2;
    public Sprite moguraImage;
    void Start()
    {
       // this.player = GameObject.Find("Player");
        //this.wear1 = GameObject.Find("wear1");
       // this.wear2 = GameObject.Find("wear2");
    }


    // Enemy1に当たり判定なし
    void OnTriggerEnter2D(Collider2D other)
    {

        // Wear2
        if (other.gameObject.tag == "wear2")
        {
            this.tag = "wear2";                // タグを変更する

            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage;


            Destroy(wear2);
        }
    }

}