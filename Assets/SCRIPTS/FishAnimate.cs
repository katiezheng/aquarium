using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Animation animationComponent; // assign in inspector

	// Update is called once per frame
	void Update () {
	 		// I'll need 2 pieces of data:
			// 1) How fast is the fish moving?
			// 2) How do I control how fast the fish animates?

		float speed = rigidbody.velocity.magnitude;
		animationComponent ["SwimLoop"].speed = speed;
	}
}
