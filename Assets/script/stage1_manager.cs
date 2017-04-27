using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class stage1_manager : Singleton<stage1_manager> {
	
	//monster in 5 level
	public GameObject[] monster = new GameObject[6];
	//timer
	float timer = 0;
	//List of monster
	List<int> a = new List<int>();
	List<Object> enemylist = new List<Object>();
	//wave of enemy instantiate
	public int wave;
	//stage 1-1 ~1-5
	public int stage;
	// Use this for initialization
	int monster_num;
	public GameObject gui;
	
	void Awake()
	{
		
	}

    
	void Start () 
	{
		gui.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
        if (timer > 3)
        {
			if(enemylist.Count==0)
			{
				summon();
				wave++;
			}

			timer = 0;
        }
	}

	void summon()
	{
		switch (stage)
		{
			case 1:
				switch (wave) 
				{
					case 0:
						enemylist.Add(Instantiate(monster[0], new Vector2(2.0f, 0), Quaternion.identity));
						break;
					case 1:
						enemylist.Add(Instantiate(monster[0], new Vector2(2.0f, 0), Quaternion.identity));
						enemylist.Add(Instantiate(monster[0], new Vector2(-2.0f, 0), Quaternion.identity));
						break;
					case 2:
						enemylist.Add(Instantiate(monster[0], new Vector2(2.0f, -0.5f), Quaternion.identity));
						enemylist.Add(Instantiate(monster[0], new Vector2(-2.0f, -0.5f), Quaternion.identity));
						enemylist.Add(Instantiate(monster[0], new Vector2(0,2.5f), Quaternion.identity));
						break;
					case 3:
						gui.SetActive(true);
						break;
				}

				break;
///////////////////////////////////////////////////////////////////////////////////////////////////////
			case 2:
				switch (wave) 
				{
					case 1:

						break;
					case 2:

						break;
					case 3:

						break;
				}

			break;
///////////////////////////////////////////////////////////////////////////////////////////////////////
			case 3:
				switch (wave) 
				{
					case 1:

						break;
					case 2:

						break;
					case 3:

						break;
				}

			break;
///////////////////////////////////////////////////////////////////////////////////////////////////////
			case 4:
				switch (wave) 
				{
					case 1:

						break;
					case 2:

						break;
					case 3:

						break;
				}

			break;
///////////////////////////////////////////////////////////////////////////////////////////////////////
			case 5:
				switch (wave) 
				{
					case 1:

						break;
					case 2:

						break;
					case 3:

						break;
				}

			break;
				     
		}
				
	}
	
	public void removegameobject(GameObject target)
	{
		enemylist.Remove(target);
	}

}