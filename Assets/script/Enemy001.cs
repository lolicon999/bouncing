using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy001 : MonoBehaviour {

	public GameObject laserPrefab;
	public int attack;
	float timeCounter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;

		if(timeCounter>4.0f)
		{
			shootLaser();
			timeCounter -= timeCounter;
		}


	}

	void shootLaser()
	{
		GameObject[] newLaser = new GameObject[4];
		Vector3 pos = gameObject.transform.position;
		float rotZ = gameObject.transform.rotation.eulerAngles.z;

		newLaser[0] = Instantiate(laserPrefab,pos,Quaternion.Euler(new Vector3(0,0,0+rotZ)));
		newLaser[1] = Instantiate(laserPrefab,pos,Quaternion.Euler(new Vector3(0,0,90+rotZ)));
		newLaser[2] = Instantiate(laserPrefab,pos,Quaternion.Euler(new Vector3(0,0,180+rotZ)));
		newLaser[3] = Instantiate(laserPrefab,pos,Quaternion.Euler(new Vector3(0,0,270+rotZ)));

		newLaser[0].GetComponent<Rigidbody2D>().AddForce(1000*new Vector2(Mathf.Cos(rotZ*Mathf.Deg2Rad),Mathf.Sin(rotZ*Mathf.Deg2Rad)));
		newLaser[1].GetComponent<Rigidbody2D>().AddForce(1000*new Vector2(Mathf.Cos((rotZ+90)*Mathf.Deg2Rad),Mathf.Sin((rotZ+90)*Mathf.Deg2Rad)));
		newLaser[2].GetComponent<Rigidbody2D>().AddForce(1000*new Vector2(Mathf.Cos((rotZ+180)*Mathf.Deg2Rad),Mathf.Sin((rotZ+180)*Mathf.Deg2Rad)));
		newLaser[3].GetComponent<Rigidbody2D>().AddForce(1000*new Vector2(Mathf.Cos((rotZ+270)*Mathf.Deg2Rad),Mathf.Sin((rotZ+270)*Mathf.Deg2Rad)));
		//Debug.Log(Mathf.Cos(rotZ));
		//Debug.Log(Mathf.Sin(rotZ));
		//newLaser[1].GetComponent<Rigidbody2D>().AddForce(1000*new Vector2(Mathf.Cos(rotZ),Mathf.Sin(rotZ)));
		//newLaser[2].GetComponent<Rigidbody2D>().AddForce(1000*new Vector2(Mathf.Cos(rotZ+90),Mathf.Sin(rotZ+90)));

	}

}
