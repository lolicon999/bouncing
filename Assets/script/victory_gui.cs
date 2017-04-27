using UnityEngine;
using System.Collections;

public class victory_gui : MonoBehaviour {


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
	public void to_stage_controll(int stage)
	{
		
		
		switch (stage)
		{
			case 1:
				Application.LoadLevel("stage1_controll");
				break;


			default:
				break;
		}


	}
}
