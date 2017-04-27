using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMoney : MonoBehaviour {

	public GameObject copperCoin;
	public GameObject silverCoin;
	public GameObject goldCoin;
	public GameObject diamandCoin;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void dropMoney(int value)
	{
		while(value>0)
		{
			if(value>=1000)
			{
				Instantiate(diamandCoin,gameObject.transform.position, Quaternion.identity);
				value -= 1000;
			}
			else if(value>=100)
			{
				Instantiate(goldCoin,gameObject.transform.position, Quaternion.identity);
				value -= 100;
			}
			else if(value>=10)
			{
				Instantiate(silverCoin,gameObject.transform.position, Quaternion.identity);
				value -= 10;
			}
			else
			{
				Instantiate(copperCoin,gameObject.transform.position, Quaternion.identity);
				value -= 1;
			}
			GameObject.Destroy(this.gameObject);
		}
	}
}
