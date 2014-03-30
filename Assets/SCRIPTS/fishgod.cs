using UnityEngine;
using System.Collections;
using System.Collections.Generic; // add this line to use "lists"

public class fishgod : MonoBehaviour {
	public Transform fishBlueprint; //assign in inspector
	List<fish> fishList = new List<fish>();


	// Use this for initialization
	void Start () {
		int counter = 0;
	
		while (counter < 5 ) {
		fish newFish = Instantiate (fishBlueprint, Random.insideUnitSphere * 10f, Random.rotation) as fish;
			fishList.Add (newFish);
			counter++; //"increment" basically means "+= 1"
		}
		}

	// Update is called once per frame
	void Update () {
		// is user holding down spacebar? then tell each Fish in fishList to swim to (0,0,0)
		if (Input.GetKey (KeyCode.Space)) {
			foreach (fish pierce in fishList ) {
				pierce.destination = Vector3.zero;
			//fishList{0}.destination = Vector3.zero;
			}
		}
	}


}
