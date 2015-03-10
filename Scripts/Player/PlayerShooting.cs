using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour 
{	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public float coolDown =  0f;

	void Update () 
	{
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		//print ("the cooldown time is " + coolDown);
		CoolDownTimer();
		if(coolDown >= 1)
		{		
			if(Input.GetKeyDown(KeyCode.Space))
			{
				Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
				coolDown = 0f;
			}
		}
	}

	void CoolDownTimer()
	{
		coolDown += Time.deltaTime;
	}
}
