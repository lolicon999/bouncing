using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DataManager : MonoBehaviour {

	// Use this for initialization
	public player_imformation playerData;
	void Awake()
	{
		loadData();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void loadData()
	{
		playerData = save_system.Load<player_imformation>(Application.dataPath+"/Save.xml");
	}
	public void saveData()
	{
		save_system.Save<player_imformation>(playerData, Application.dataPath + "/Save.xml");
	}


}
