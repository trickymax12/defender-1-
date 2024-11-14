using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xander : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D EnemyRb;
    private GameObject Player;
    public SpriteRenderer SR;
    [Header("sprites")]
    public Sprite happy;
    public Sprite scared;
    public Sprite dead;
    [Header("!sprites")]
    public float deathdelay;
    public bool HasBeenClicked = false;
    
    private Gamemanager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("Gamemanager").GetComponent<Gamemanager>();
        SR = GetComponent<SpriteRenderer>();
        EnemyRb = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookDirection = (Player.transform.position - transform.position).normalized;
        EnemyRb.AddForce(lookDirection * Speed);
    }
    private IEnumerator OnMouseDown()
    {
        if (!HasBeenClicked) 
        {
            HasBeenClicked = true;
            SR.sprite = dead;
            GM.AddScore(1);
            yield return new WaitForSeconds(deathdelay);
            Destroy(gameObject);
        }
        
    }
    private void OnMouseEnter()
    {
        if (!HasBeenClicked)
        {
            SR.sprite = scared;
        }
    }
    private void OnMouseExit()
    {
        if (!HasBeenClicked)
        {
            SR.sprite = happy;
        }
    }
}
