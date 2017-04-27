using UnityEngine;
using System.Collections;

public class summon : MonoBehaviour {

	float t=0;
	Vector2 location;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		Instantiate(prefab,new Vector2(0,0),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		t +=Time.deltaTime;
		if (t>5) {

			location = new Vector2(Random.Range (5.0f, -5.0f), Random.Range (3.0f, -3.0f));

			Instantiate(prefab,location,Quaternion.identity);
		    
            t =0.0f;
		}


	
	}
}
