using UnityEngine;
using System.Collections;

public class Save_Object_action : MonoBehaviour {

	// Use this for initialization
	void Start () {
		save_system.Save<player_imformation>( new player_imformation(), Application.dataPath + "/Save.xml");
	}

}
