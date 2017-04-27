using UnityEngine;
using System.Collections;

public class Stop_Button_Function : MonoBehaviour {

	// Use this for initialization
	public GameObject gui;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Pause_Button()
	{
		Time.timeScale = 0.0f;
		gui.SetActive(true);

	}
	public void Resume_Button()
	{
		Time.timeScale = 1.0f;
		gui.SetActive(false);

	}
}
