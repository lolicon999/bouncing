using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicImformation : MonoBehaviour {

	public float HP;
	public int money;
	GameObject summonManager;
	// Use this for initialization
	void Start () {
		summonManager = GameObject.Find("summonManager");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void hurt(float value)
	{
		HP -= value;
		//if die
		if(HP<=0)
		{
			summonManager.GetComponent<SummonManager>().enemyList.Remove(this.gameObject);
			int moneyRandom = (int) (money * Random.Range(0.8f, 1.2f)); 

			gameObject.GetComponent<DropHeal>().dropHealItem();
			gameObject.GetComponent<DropMoney>().dropMoney(moneyRandom);

		}
	}
}
