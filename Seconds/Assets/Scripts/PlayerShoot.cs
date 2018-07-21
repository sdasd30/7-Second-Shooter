﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Rigidbody projectile;
	public GameObject BulletPrefab;
	CurrentWeapon Weapon;
	public Vector2 Offset;
	float coolDown = 0;
	// Use this for initialization
	void Start () {
		Weapon = FindObjectOfType<CurrentWeapon> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && coolDown <=0){
			float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
			GameObject bullet = GameObject.Instantiate (Weapon.bullet, transform.position + new Vector3 (Offset.x * Mathf.Cos (angle), Offset.y * Mathf.Sin (angle), +.5f), Quaternion.identity);
			bullet.GetComponent<Projectile> ().SetAngle (transform.rotation.eulerAngles.z + Random.Range(-Weapon.spread,Weapon.spread) - 90);
			bullet.GetComponent<Projectile> ().SetWeapon(Weapon);
			Destroy (bullet, 5);
			coolDown = Weapon.firerate;
		}
		if (coolDown >= 0) {
			coolDown--;
		}
	}

	public float ReturnCoolDown(){
		return coolDown;
	}
}
