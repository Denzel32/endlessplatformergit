using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
    public int enemyHealth = 100;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ARROW")
        {
            enemyHealth -= 100;
        }
                       
        if(enemyHealth <= 0)
        {
            print("death");
        }
    }
}
