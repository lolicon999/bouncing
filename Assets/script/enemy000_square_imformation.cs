using UnityEngine;
using System.Collections;

public class enemy000_square_imformation : MonoBehaviour {

    public float hp;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void hurt(float damage)
    {
        hp = hp - damage;
        if(hp<=0)
        {
			Debug.Log(hp);
			//stage1_manager.instance.removegameobject(gameObject);
            gameObject.GetComponent<droping_item>().die_droping();
            Destroy(this.gameObject);
        }
        return;
    }
}
