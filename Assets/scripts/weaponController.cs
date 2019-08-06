using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour {
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
       
        InvokeRepeating("Fire",delay,fireRate);
		
	}
	void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        //GetComponent<AudioSource>().Play();  
    }

}
