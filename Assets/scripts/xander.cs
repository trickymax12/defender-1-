using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xander : MonoBehaviour
{
    public float speed;
    public GameObject Player;
    private Rigidbody2D EnemyRb;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookdirection = (Player.transform.position - transform.position).normalized;
        EnemyRb.AddForce(lookdirection * speed);
    }
}
