using UnityEngine;
using System.Collections;

public class stage1_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void to_stage(int stage)
	{
		switch(stage)
		{
			case 1 : 
				Application.LoadLevel("stage1-1");
				break;
			case 2 :
				Application.LoadLevel("stage1-2");
				break;
			case 3 :
				Application.LoadLevel("stage1-3");
				break;
			case 4 :
				Application.LoadLevel("stage1-4");
				break;
			case 5 :
				Application.LoadLevel("stage1-5");
				break;


		}




	}


}
