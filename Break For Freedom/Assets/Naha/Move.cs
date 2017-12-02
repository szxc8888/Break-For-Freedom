using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    //生成するゲームオブジェクト
    GameObject player, wear1, wear2, wear3;
    public Sprite moguraImage;
    public Sprite moguraImage2;
    public Sprite moguraImage3;



    void Start()
    {
        this.player = GameObject.Find("Player");
        this.wear1 = GameObject.Find("wear1");
    this.wear2 = GameObject.Find("wear2");
    this.wear3 = GameObject.Find("wear3");
    }
    // Update is called once per frame
    void Update()
    {


        // (↑)上に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }
        // (↓)下に移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }
        // (←)左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        // (→)右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0); ;

        }
    }
    // 服に触れたら着替える
    void OnTriggerEnter2D(Collider2D other)
    {
        //Wear1
        if (other.gameObject.tag == "wear1")
        {
            this.tag = "wear1";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage;
        
            Destroy(wear1);
        }

        // Wear2
        if (other.gameObject.tag == "wear2")
        {
            this.tag = "wear2";                // タグを変更する
           SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage2;

            Destroy(wear2);
       }

       // // Wear3
        if (other.gameObject.tag == "wear3")
        {
            this.tag = "wear3";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
           renderer.sprite = moguraImage3;

           Destroy(wear3);
       }
    }
}