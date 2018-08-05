using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour {

	public GameObject bullet;
	public float spread;
	public float firerate;
	public float damage;
	public float speed;
	public float duration;
	public bool auto;

	public void debugout(){
		Debug.Log ("GO:" + bullet);
		Debug.Log ("SP:" + spread);
		Debug.Log ("FR:" + firerate);
		Debug.Log ("DM:" + damage);
		Debug.Log ("SP:" + speed);
	}

}
