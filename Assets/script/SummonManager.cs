using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonManager : MonoBehaviour {
	[System.Serializable]
	public class Round
	{
		public GameObject[] type;
		public int[] num;
	}
	public GameObject victoryUI;
	public List<GameObject> enemyList=new List<GameObject>();
	public Round[] summonLine;
	int counter;
	float time=0;
	//public int[] a;
	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time>=3.0f&&enemyList.Count==0)
		{
			
			if(counter==summonLine.Length)
			{
				victoryUI.SetActive(true);
			}
			time-=time;
			summon();
		}

	}

	public bool summon()
	{
		

		Round now = summonLine[counter];
		int s = now.type.Length;
		for(int c1=0;c1<s;c1++)
		{
			int ss = now.num[c1];
			for(int c2=0;c2<ss;c2++)
			{
				Vector3 pos = new Vector3(Random.Range(-8.0f,8.0f), Random.Range(-3.0f,3.0f), 0);
				enemyList.Add(Instantiate(now.type[c1], pos, Quaternion.identity));
			}

		}

		counter++;

		return true;
	}
}
