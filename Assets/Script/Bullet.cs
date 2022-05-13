using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int damage;
    public float speed;
    public float bulletDistance;

    private Rigidbody2D rg2d;
    private Vector3 starPos;
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        rg2d.velocity = transform.right * speed;
        starPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (transform.position - starPos).sqrMagnitude;
        if (distance > bulletDistance)
        {
            Destroy(gameObject);
        }
    }



}