using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UImanager : MonoBehaviour {

	//in battle
	public RectTransform bloodStrips;
	public GameObject stopGui;
	public DataManager dataManager;

	//in upgrade
	public Text hp;
	public Text money;
	public Text atk;

	void Start()
	{
		UIUpdata();
	}
	public void updataHP(float value)
	{
		//Vector3 bloodStripsY = new Vector3(1,0,1);
		//bloodStripsY.y = value;
		bloodStrips.sizeDelta = new Vector2(100,100*value);

	}

	public void Pause()
	{
		Time.timeScale = 0.0f;
		stopGui.SetActive(true);
	}
	public void Resume()
	{
		Time.timeScale = 1.0f;
		stopGui.SetActive(false);
	}
	public void toMenu()
	{
		dataManager.saveData();
		Application.LoadLevel("menu");
	}

	public void upgrade()
	{
		if(dataManager.playerData.money<10)
		{
			return;
		}
		dataManager.playerData.money -= 10;
		dataManager.playerData.MaxHP += 10;
		dataManager.playerData.Attack += 5;
		UIUpdata();
		dataManager.saveData();
	}
	void UIUpdata()
	{
		hp.text = "HP : " + dataManager.playerData.MaxHP;
		money.text ="MONEY : "+ dataManager.playerData.money;
		atk.text = "ATTACK : "+dataManager.playerData.Attack;
	}

	public void toUpgrade()
	{
		Application.LoadLevel("upgrade");
	}

	public void toBattle()
	{
		Application.LoadLevel("stage1_controll");
	}
	public void toStage1_1()

	{
		Application.LoadLevel("stage1_1");
	}

	public void toStage1_2()
	{
		Application.LoadLevel("stage1_2");
	}
	public void toStage1_3()
	{
		Application.LoadLevel("stage1_3");
	}


}