using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wear3 : MonoBehaviour
{
    //生成するゲームオブジェクト
    GameObject player, wear1, wear2, wear3;
    public Sprite moguraImage;
    void Start()
    {
        //this.player = GameObject.Find("Player");
        //this.wear1 = GameObject.Find("wear1");
        //this.wear2 = GameObject.Find("wear2");
        //this.wear3 = GameObject.Find("wear3");
    }


    // Enemy1に当たり判定なし
    void OnTriggerEnter2D(Collider2D other)
    {

        // Wear2
        if (other.gameObject.tag == "wear3")
        {
            this.tag = "wear3";                // タグを変更する

            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage;


            Destroy(wear3);
        }
    }

}