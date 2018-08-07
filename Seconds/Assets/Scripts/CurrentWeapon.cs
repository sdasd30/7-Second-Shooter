using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour {

	public GameObject bullet;
	public string name; //Has no effect on gameplay, is just for ID purposes.
	public float spread; //In degrees.
	public float firerate; //In miliseconds.
	public float damage;
	public float speed; //Projectile Speed.
	public float duration; //How long the bullet lasts in seconds.
	public int shots; //How many shots does the gun shoot at once?
	public bool auto; //Is full auto?

}
