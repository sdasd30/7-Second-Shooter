using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemaining : MonoBehaviour {
	public GameObject WeaponHandler;
	public Weapons theWeapon;
	Slider me;
	// Use this for initialization
	void Start () {
		me = GetComponent<Slider> ();
		theWeapon = WeaponHandler.GetComponent<Weapons> ();
	}

	// Update is called once per frame
	void Update () {
		me.maxValue = theWeapon.weaponSwitchDelay;
		me.value = 7 - theWeapon.cooldown;
	}
}
