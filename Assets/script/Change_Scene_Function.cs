using UnityEngine;
using System.Collections;

public class Change_Scene_Function : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void start_button()
	{
		Application.LoadLevel("menu");
	}
	public void Battle_Button()
	{
		Application.LoadLevel("stage1_controll");
	}


}
