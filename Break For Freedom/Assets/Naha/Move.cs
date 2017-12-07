using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    GameObject player, wear1, wear2, wear3, key1, Door1,Door12;


    public Sprite moguraImage;
    public Sprite moguraImage2;
    public Sprite moguraImage3;
     //  public bool isActive = true;



    void Start()
    {
        this.player = GameObject.Find("Player");
        this.wear1 = GameObject.Find("wear1");
        this.wear2 = GameObject.Find("wear2");
        this.wear3 = GameObject.Find("wear3");

        this.key1 = GameObject.Find("key1");
        this.Door1 = GameObject.Find("Door1");

 
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
            transform.Translate(0.1f, 0, 0);
        }

    }
    // 服に触れたら着替える
    void OnTriggerEnter2D(Collider2D other)
    {
        //Wear1に触れたら着替える
        if (other.gameObject.tag == "wear1")
        {

            this.tag = "wear1";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage;     // 画像変更枠追加

            // Destroy(wear1);      // Wear1削除
            //   wear1.SetActive(true);
        }


        // Wear2に触れたら着替える
        if (other.gameObject.tag == "wear2")
        {
            this.tag = "wear2";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage2;    // 画像変更枠追加

            //  Destroy(wear1);    // Wear1削除
            //  Destroy(wear2);    // Wear2削除
        }

        // Wear3に触れたら着替える
        if (other.gameObject.tag == "wear3")
        {
            this.tag = "wear3";                // タグを変更する
            SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();        // 画像を差し替える
            renderer.sprite = moguraImage3;    // 画像変更枠追加

            //  Destroy(wear1);      // Wear1削除
            //  Destroy(wear2);      // Wear2削除
            //  Destroy(wear3);      // Wear3削除

        }
    }
}