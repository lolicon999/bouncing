using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player_Manager : MonoBehaviour {
	
	
	//self component
	Rigidbody2D rigidBody;
	AudioSource playerSound;
	public AudioClip hitSound;
	public AudioClip healSound;
	Transform transform;


	//basic imformation
	public DataManager dataManager;
	private float maxHP=10;
	private float currentHP=10;
	private float ATK=2;

	//outside object

	//UI controll
	public UImanager uiManager;

	//camera
	public Camera camera;
	public float shakingDuration;
	public float shakingDensity;

	// Use this for initialization
	void Start () {
		rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
		playerSound = this.gameObject.GetComponent<AudioSource>();
		transform  = this.gameObject.GetComponent<Transform>();
		maxHP = dataManager.playerData.MaxHP;
		currentHP = maxHP;
		ATK = dataManager.playerData.Attack;
	}
	
	// Update is called once per frame
	Vector2 downPosition,upPosition;
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			downPosition = Input.mousePosition;
		}

		if(Input.GetMouseButtonUp(0))
		{
			upPosition = Input.mousePosition;
			Vector2 dir =(downPosition - upPosition);
			rigidBody.AddForce(0.1f*dir* Mathf.Rad2Deg);
			transform.rotation =  Quaternion.Euler(new Vector3(0,0,90+Mathf.Rad2Deg*Mathf.Atan2((downPosition.y - upPosition.y) , (downPosition.x - upPosition.x))));
		}


	}


	//get the imformation from savedata class at the begining
	public void initPlayer()
	{
		
	}

	public void setHP(float value)
	{
		Debug.Log(value);
		currentHP += value;
		if (currentHP > maxHP)
			currentHP = maxHP;

		if(value>0)//heal
		{
			playerSound.PlayOneShot(healSound, 1.0f);
		}
		else//get damage
		{
			checkDie();		
		}
		uiManager.updataHP(currentHP/maxHP);
	}
	public void getMoney(int value)
	{
		dataManager.playerData.money += value;
	}


	private void checkDie()
	{

		if(currentHP<=0)
		{
			currentHP = 0;
			//do the thing player die
			dataManager.saveData();
			GameObject.Destroy(this.gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D obstacle)
	{
		string name = obstacle.collider.name;
		string tag = obstacle.collider.tag;

		if(name=="background")
		{
			playerSound.PlayOneShot(hitSound, 1.0F);
			camera.transform.DOShakePosition (shakingDuration, shakingDensity);

		}

		if(tag =="enemy")
		{
			playerSound.PlayOneShot(hitSound ,1.0F);
			float a = ATK;
			if(Random.Range(0,10.0f)>9.0f)
			{
				a = a * 2;//criticalhit
			}
			else
			{
				a = Random.Range(a / 2, a); //damage from 50%maxdamage to 100%max_damage;
			}
			//Debug.Log(a);
			obstacle.gameObject.GetComponent<EnemyBasicImformation>().hurt(a);
		}

	}

	/// <summary>
	/// OnCollisionExit is called when this collider/rigidbody has
	/// stopped touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionExit(Collision other)
	{
		if(other.gameObject.name=="background")
		{

		}
	}
	
}
