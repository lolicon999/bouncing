using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	// Use this for initialization
	public float damage=1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D obstacle)
	{
		//Debug.Log("in");
		string name = obstacle.gameObject.name;

		if(name=="background")
		{
			GameObject.Destroy(this.gameObject);
		}
		else if(name=="Circle")
		{
			obstacle.gameObject.GetComponent<Player_Manager>().setHP(-damage);
			GameObject.Destroy(this.gameObject);
		}
	}
}
