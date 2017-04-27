using UnityEngine;
using System.Collections;

public class stage1_1init : MonoBehaviour {

	// Use this for initialization
	public int level;
	
	void Start () {
		stage1_manager.instance.stage = level;
		stage1_manager.instance.wave = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
