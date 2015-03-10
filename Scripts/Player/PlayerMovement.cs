using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	public float moveSpeed = 10.0f;
	private bool jump = false; 		//true will let player jump, false won't allow player to jump.
	public float js = 100.0f;			//private float for jump speed
	private Animator animator;
    public bool facingRight;

	void Start()
	{
		animator = GetComponent<Animator>();
	}
	void Update () 
	{
		//movement for the D key.
		if(Input.GetKey(KeyCode.D))
		{	
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
			animator.SetBool("isWalking", true);
               if(facingRight)
               {
                Flip();      
               }
		}
		//movement for the A key.
		if(Input.GetKey(KeyCode.A))
		{	
			transform.Translate(Vector2.right *- moveSpeed * Time.deltaTime);
           
            if (!facingRight)
            {
                Flip();
            }
		}
		//to make the player jump
		if(Input.GetKeyDown(KeyCode.W))
		{	
			//animator.SetTrigger("isJumping");
			if(jump == true)
			{	
				GetComponent<Rigidbody2D>().velocity = Vector2.up * js;
				jump = false;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collide)
	{
		if(collide.gameObject.tag == "Ground")
		{
			jump = true;
		}
	}

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
