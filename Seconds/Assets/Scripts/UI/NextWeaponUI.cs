using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWeaponUI : MonoBehaviour {
	public GameObject WeaponHandler;
	public GameObject theWeapon;
	public Sprite weaponSprite;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		theWeapon = WeaponHandler.GetComponent<Weapons> ().nextWeapon;
		weaponSprite = theWeapon.GetComponent<SpriteRenderer> ().sprite;
		GetComponent<Image> ().sprite = weaponSprite;
	}
}
