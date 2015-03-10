using UnityEngine;
using System.Collections;

public class EnemyLook : MonoBehaviour 
{
	public Transform startSight;
	public Transform endSight;
	public float moveSpeed = 10;
	//public EnemyFire fire; //reference to the enemyfire script

	public bool spotted = false;

	// Update is called once per frame
	void Update () 
	{
		RayCasting ();
		Behaviours();
	}

	void RayCasting()
	{	
		//Drawing a line from the startsight to endsight. Only allowing it to see the object that has the player layer tag.
		Debug.DrawLine(startSight.position, endSight.position, Color.green);
		spotted = Physics2D.Linecast(startSight.position, endSight.position, 1 << LayerMask.NameToLayer("Player"));

	}

	void Behaviours()
	{
		if(spotted == true)
		{	
			GetComponent<Rigidbody2D>().velocity = Vector2.right *- moveSpeed * Time.deltaTime;
			//gameObject.GetComponent<EnemyFire>().Timer(); //this gets the Timer function from the EnemyFire script.
		}
	}
}
