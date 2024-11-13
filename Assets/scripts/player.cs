using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float HorizontalInput;
    public float VerticalInput;
    public Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * Time.deltaTime * speed * VerticalInput);
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * turnSpeed * HorizontalInput);
    }
}
