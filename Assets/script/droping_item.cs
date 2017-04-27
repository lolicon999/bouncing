using UnityEngine;
using System.Collections;

public class droping_item : MonoBehaviour {


	public GameObject [] Money = new GameObject[4];
    public GameObject healing;
    public int droping_wave;//set bigger than three
    public float droping_range;
	public int money_num;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void die_droping()
    {
        int times = droping_wave;
        times = times + (int)Random.Range(-droping_range, droping_range);
        int c1;
        for(c1=0;c1<times;c1++)
        {
            Instantiate(healing, gameObject.transform.position, Quaternion.identity);
        }



    }
}
