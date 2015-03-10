using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour 
{	
	public float arrowSpeed;
    private Vector3 targetpos;

	// Use this for initialization++++
	void Start () 
	{
        targetpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
	
	// Update is called once per frame
	void Update () 
	{
         
        transform.position = Vector3.MoveTowards(transform.position, targetpos, arrowSpeed * Time.deltaTime);
	}
}
