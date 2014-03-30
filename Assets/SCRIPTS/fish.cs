using UnityEngine;
using System.Collections;

public class fish : MonoBehaviour {

	public Vector3 destination;

	// Use this for initialization
	void Start () {
		// after 0 second, it will randomize its destination every 10 sec.
		InvokeRepeating ("RandomizeDestination", 0f, 5f);
	}
	void RandomizeDestination () {
		destination = Random.insideUnitSphere * 10f;
}
	
	// Update is called once per frame
	void FixedUpdate () {
		// always move toward "destination"
		rigidbody.AddForce (Vector3.Normalize (destination - transform.position));

	}
	void Update () {
		//destination = Random.insideUnitSphere * 100f;
		// always look the direction you're moving
		transform.rotation = Quaternion.LookRotation (rigidbody.velocity);
	}
}
