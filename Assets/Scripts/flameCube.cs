using UnityEngine;
using System.Collections;

public class flameCube : MonoBehaviour {

	public new ParticleSystem cubeOnFire;

	// Use this for initialization
	void Start () {
		cubeOnFire.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "Fire") {
			cubeOnFire.Play();
		}
	}
}
