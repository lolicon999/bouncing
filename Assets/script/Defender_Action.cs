using UnityEngine;
using System.Collections;
using DG.Tweening;
public class Defender_Action : MonoBehaviour {

	// Use this for initialization
	public int Shield_Hp;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D obstacle)
	{
		string name = obstacle.collider.name;
		if (name == "Circle") 
		{
			Shield_Hp--;
			if (Shield_Hp == 0) 
			{
				obstacle.gameObject.transform.localScale =new Vector3(0, 0, 0); 
			}
		}
	}

	/*void Shield_activate()
	{
		Shield_switch();
		gameObject.transform.DOScale(new Vector3(2,2,0),1.0f).WaitForCompletion(Shield_switch);
	}

	void Shield_switch()
	{
		gameObject.GetComponent<PolygonCollider2D>().enabled = !gameObject.GetComponent<PolygonCollider2D>().enabled;
	}

*/
}
