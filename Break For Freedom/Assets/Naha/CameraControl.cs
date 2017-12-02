using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{


    GameObject player, player2;

    void Start()
    {
        this.player = GameObject.Find("Player");
        this.player2 = GameObject.Find("Enemy11");
    }


    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.x, transform.position.z);
        transform.position = new Vector3(transform.position.y, playerPos.y, transform.position.z);
    }
}
