using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Enemy1 : MonoBehaviour
{

    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 580.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 4.5f;


    void Start()
    {

        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {




        // 左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // プレイヤーの速度
        //float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        //if (speedx < this.maxWalkSpeed)
        //{
        //   this.rigid2D.AddForce(transform.right * key * this.walkForce);
        //}

        // 動く方向に応じて反転(追加)
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // プレイヤーの速度に応じてアニメーションアニメーション速度を変える
        //if (this.rigid2D.velocity.y == 0)
        //{
        //    this.animator.speed = speedx / 2.0f;
        //}
        //else
        //{
        //    this.animator.speed = 1.0f;
        //}
        // 画面外に出た場合は最初から
        // if (transform.position.y < -5)
        //{
        //    SceneManager.LoadScene("GameScene");
        //}

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Enemy");
        }
    }

    // ゴールに到着
    // void OnTriggerEnter2D(Collider2D other)
    //{

    // other.isTrigger = false;
    //  Debug.Log("ゴール");
    //      SceneManager.LoadScene("ClearScene");
}

// }

