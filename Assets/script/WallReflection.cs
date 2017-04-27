using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallReflection : MonoBehaviour {

	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	
	public enum Wall{
	Left,
	Right,
	Up,
	Down
};
	
	public Wall wall;
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.name =="Circle")
		{
			float nowRotateZ = other.gameObject.transform.rotation.eulerAngles.z;
			float rotateValue=0;
			if(nowRotateZ>180)
			{
				nowRotateZ = nowRotateZ-360;
			}
			Debug.Log(nowRotateZ);
			switch(wall)
			{
				case Wall.Up:
					if(nowRotateZ>=0)
					{
						rotateValue = 180-nowRotateZ;
					}
					else
					{
						rotateValue = -180+Mathf.Abs(nowRotateZ);
					}
				break;
				case Wall.Down:
					if(nowRotateZ>=0)
					{
						rotateValue = 180-nowRotateZ;
					}
					else
					{
						rotateValue = -180+Mathf.Abs(nowRotateZ);
					}
				break;
				case Wall.Left:
						rotateValue = Mathf.Abs(nowRotateZ);
				break;
				case Wall.Right:
						rotateValue = -1*nowRotateZ;
				break;

			}
			Debug.Log(rotateValue);
			other.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0,0,rotateValue));
		}
	}



}
