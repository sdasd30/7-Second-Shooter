using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject projectilePrefab;

	// public GameObject directionalObject;
	private List<GameObject> Projectiles = new List<GameObject>();
	private float projectileVelocity;

	void Start () {
		projectileVelocity = 20;
	}
	
	void Update () {
		
		if(Input.GetButtonDown("Shoot")) {
			GameObject bullet = (GameObject)Instantiate(projectilePrefab, transform.position, Quaternion.identity);
			// I tried replacing "Quaternion.identity" with "directionalObject.transform.rotation"
			Projectiles.Add(bullet);
		}
		
		for(int i = 0; i < Projectiles.Count; i++) {
			GameObject goBullet = Projectiles[i];
			if(goBullet != null) {
				goBullet.transform.Translate(new Vector3(1, 0) * Time.deltaTime * projectileVelocity);
				//I tried replacing "Vecto3(1, 0)" with "Vector3(directionalObject.transform.rotation.x, directionalObject.transform.rotation.y)"
				Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint(goBullet.transform.position);
				if(bulletScreenPos.x >= Screen.width || bulletScreenPos.y >= Screen.height || bulletScreenPos.y <= 0 || bulletScreenPos.x <= 0) {
					DestroyObject(goBullet);
					Projectiles.Remove(goBullet);
				}
			
			}
		}
	}
}
