using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
	//public Rigidbody projectile;
	//public GameObject BulletPrefab;
	CurrentWeapon Weapon;
	public Vector2 Offset;
	public Sprite beginLaser;
	public Sprite endLaser;
	bool firstFire;
	float coolDown = 0;
	// Use this for initialization
	void Start () {
		Weapon = GetComponent<CurrentWeapon> ();
		firstFire = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
			GameObject bullet = GameObject.Instantiate (Weapon.bullet, transform.position + new Vector3 (Offset.x * Mathf.Cos (angle), Offset.y * Mathf.Sin (angle), +.5f), Quaternion.identity);
			bullet.GetComponent<Projectile> ().SetAngle (transform.rotation.eulerAngles.z + Random.Range (-Weapon.spread, Weapon.spread) - 90);
			bullet.GetComponent<Projectile> ().SetWeapon (Weapon);
			bullet.GetComponent<SpriteRenderer> ().sprite = beginLaser;
			Debug.Log ("Donn1");
			Destroy (bullet, Weapon.duration);
			firstFire = true;
			coolDown = Weapon.firerate;
		}
		if (coolDown <= 0) {
			if (Input.GetButton ("Fire1") && firstFire) {
				float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
				GameObject bullet = GameObject.Instantiate (Weapon.bullet, transform.position + new Vector3 (Offset.x * Mathf.Cos (angle), Offset.y * Mathf.Sin (angle), +.5f), Quaternion.identity);
				bullet.GetComponent<Projectile> ().SetAngle (transform.rotation.eulerAngles.z + Random.Range (-Weapon.spread, Weapon.spread) - 90);
				bullet.GetComponent<Projectile> ().SetWeapon (Weapon);
				Destroy (bullet, Weapon.duration);
				coolDown = Weapon.firerate;
			} 
		}
		if (Input.GetButtonUp ("Fire1")) {
			firstFire = false;
			float angle = (transform.rotation.eulerAngles.z + 90) * Mathf.Deg2Rad;
			GameObject bullet = GameObject.Instantiate (Weapon.bullet, transform.position + new Vector3 (Offset.x * Mathf.Cos (angle), Offset.y * Mathf.Sin (angle), +.5f), Quaternion.identity);
			bullet.GetComponent<Projectile> ().SetAngle (transform.rotation.eulerAngles.z + Random.Range (-Weapon.spread, Weapon.spread) - 90);
			bullet.GetComponent<Projectile> ().SetWeapon (Weapon);
			bullet.GetComponent<SpriteRenderer> ().sprite = endLaser;
			Debug.Log ("Donn2");
			Destroy (bullet, Weapon.duration);
		}
		if (coolDown >= 0) {
			coolDown-= 1* Time.deltaTime;
		}
	}


	public float ReturnCoolDown(){
		return coolDown;
	}
}
