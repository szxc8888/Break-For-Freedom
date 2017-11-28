using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{


    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetKey("up")) 
        //{
        //    transform.position += transform.forward * speed * Time.deltaTime;
        //}
        //if (Input.GetKey("down"))
        //{
        //    transform.position -= transform.forward * speed * Time.deltaTime;
        //}
        //if (Input.GetKey("right")) 
        //{
        //    transform.position += transform.right * speed * Time.deltaTime;
        //}
        //if (Input.GetKey("left")) 
        //{
        //    transform.position -= transform.right * speed * Time.deltaTime;
        //}
   // }
//}
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
}