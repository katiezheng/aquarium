using UnityEngine;
using System.Collections;

public class raycastdemo : MonoBehaviour {

	public Transform blueprint; //assign in inspector

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
						//construct Ray and RaycastHit before actually shooting the Raycast
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit rayHit = new RaycastHit (); // blank container for info
						// actually shoot the raycast now
						if (Physics.Raycast (ray, out rayHit, 1000f)) {
								transform.LookAt (rayHit.point);
						Instantiate ( blueprint, rayHit.point, Quaternion.identity );
						// if I hold down left-click and right-click then...
						if ( Input.GetMouseButton (1) ) {
					Destroy (rayHit.transform.gameObject);
								}
						}
				}
	}
}