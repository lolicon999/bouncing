using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy000 : MonoBehaviour {

	public GameObject laser;
	public float damage = 1.0f;
	float counter=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		if(counter>3.5f)
		{
			Instantiate(laser, gameObject.transform.position, Quaternion.identity).GetComponent<laser_action>().damage = this.damage;
			counter -= counter; 
		}
	}
}
