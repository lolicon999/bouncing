using UnityEngine;
using System.Collections;

public class laser_action : MonoBehaviour {

    public float damage;
    GameObject target;
    Rigidbody2D rb;
    Transform tf;
    Vector3 dir;
    void Awake()
    {
        tf = gameObject.transform;
        target = GameObject.Find("Circle");
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

	// Use this for initialization
	void Start () {
        dir = target.transform.localPosition - tf.localPosition;

        Vector3 temp;
        temp.x = 0;
        temp.y = 0;
        temp.z = Mathf.Rad2Deg*Mathf.Atan((target.transform.localPosition.y - tf.localPosition.y) / (target.transform.localPosition.x - tf.localPosition.x));
        tf.rotation = Quaternion.Euler(temp);
		rb.AddForce(dir.normalized * 500);

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D obstacle)
    {
        string name = obstacle.name;

        
        if(name=="background")
        {
            Destroy(gameObject);
        }
        else if(name=="Circle")
        {
			obstacle.gameObject.GetComponent<Player_Manager>().setHP(-1.0f*damage);
			//Debug.Log(-1.0f * damage);
            Destroy(gameObject);
         
        }

    }


}
