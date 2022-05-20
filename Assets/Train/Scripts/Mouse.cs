using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		public GameObject support;
	// Update is called once per frame
	void Update () {
				if (Input.GetMouseButtonDown (0)) {
						support.SetActive (false);
				}
	}
}
