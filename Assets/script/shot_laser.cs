using UnityEngine;
using System.Collections;

public class shot_laser : MonoBehaviour {

    public GameObject prefab;
    float timer = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if(timer>=3)
        {
            summon_laser();
            timer = 0;
        }
	
	}
    void summon_laser()
    {
        Instantiate(prefab, gameObject.transform.localPosition, Quaternion.identity);
    }

}
