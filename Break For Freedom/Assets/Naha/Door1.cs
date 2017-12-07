using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{

    GameObject player, wear1, wear2, wear3, key1, Door1;


    public Sprite moguraImage;
    public Sprite moguraImage2;
    public Sprite moguraImage3;
    //   public bool isActive = true;



    void Start()
    {
        this.player = GameObject.Find("Player");
        this.wear1 = GameObject.Find("wear1");
        this.wear2 = GameObject.Find("wear2");
        this.wear3 = GameObject.Find("wear3");
        this.key1 = GameObject.Find("key1");
        this.Door1 = GameObject.Find("Door1");

        //        this.key1 = GameObject.Find("key1");


    }
    // Update is called once per frame
    void Update()
    {

    }
    // 服に触れたら着替える
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Enemy");
        }
        if (other.gameObject.tag == "wear1")
        {
            SceneManager.LoadScene("Enemy");
        }
        if (other.gameObject.tag == "wear2")
        {
            SceneManager.LoadScene("Enemy");
        }
        if (other.gameObject.tag == "wear3")
        {
            SceneManager.LoadScene("Enemy");
        }
        if (other.gameObject.tag == "wear4")
        {
            SceneManager.LoadScene("Enemy");
        }
    }
}
