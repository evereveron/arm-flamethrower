using UnityEngine;
using System.Collections;

public class flamethrower : MonoBehaviour {
	
	public new ParticleSystem flames;
	
	// Use this for initialization
	void Start () {
		flames.emissionRate = 0.0f;
		GameObject.Find("FlameCollider").GetComponent<Collider>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			flames.emissionRate = 1000.0f;
			GameObject.Find("FlameCollider").GetComponent<Collider>().enabled = true;

		} else {
			flames.emissionRate = 0.0f;
			GameObject.Find("FlameCollider").GetComponent<Collider>().enabled = false;

		}
	}

}
