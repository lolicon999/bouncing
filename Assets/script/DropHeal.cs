using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHeal : MonoBehaviour {

	public GameObject healItem;
	int healPoint=2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void dropHealItem()
	{
		int times = 5 + (int)Random.Range(-2.0f, 2.1f);
		for(int c1=0;c1<times;c1++)
		{
			Instantiate(healItem,gameObject.transform.position, Quaternion.identity).GetComponent<item_heal_action>().heal_point = healPoint;
		}

	}
}
