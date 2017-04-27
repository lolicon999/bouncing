using UnityEngine;
using System.Collections;

public class item_heal_action : MonoBehaviour {
    public int heal_point;
    Rigidbody2D rb;
    // Use this for initialization
    Collider2D c;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rb.AddForce(dir * 20);
        c = gameObject.GetComponent<Collider2D>();
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D obstacle)
    {
        string name = obstacle.name;
        if (name=="Circle")
        {
           
			obstacle.gameObject.GetComponent<Player_Manager>().setHP(heal_point);
            Destroy(gameObject);
        }
        else if(name=="background")
        {
            c.isTrigger = false;

        }
    }
    void OnTriggerStay2D(Collider2D obstacle)
    {
        string name = obstacle.name;
       
        if (name == "background")
        {
            c.isTrigger = true;

        }
    }

    void OnCollisionExit2D(Collision2D obstacle)
    {
        string name = obstacle.collider.name;
        if (name == "background")
        {
            c.isTrigger = true;

        }
    }

    void OnCollisionEnter2D(Collision2D obstacle)
    {
        string name = obstacle.collider.name;
        if (name == "Circle")
        {
            
            c.isTrigger = true;
			obstacle.gameObject.GetComponent<Player_Manager>().setHP(heal_point);
            Destroy(gameObject);

        }

    }

    void OnCollisionStay2D(Collision2D obstacle)
    {
        string name = obstacle.collider.name;
        if (name == "background")
        {
            c.isTrigger = true;

        }
    }



}
