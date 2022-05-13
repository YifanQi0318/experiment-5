using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float runSpeed;
    public float jumpSpeed;
    private Animator myAnim;
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
        Run();
    }

    void Flip()
    {
        bool playerHasAxisSpeed = Mathf.Abs(myRigidbody.velocity.x)>Mathf.Epsilon;
        if(playerHasAxisSpeed)
        {
            if(myRigidbody.velocity.x > 0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if(myRigidbody.velocity.x < -0.1f)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }

    void Run()
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVe1 = new Vector2(moveDir * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVe1;
        bool playerHasAxisSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        myAnim.SetBool("RUN", playerHasAxisSpeed);
    }


}
