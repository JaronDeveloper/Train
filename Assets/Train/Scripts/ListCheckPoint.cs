using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListCheckPoint : MonoBehaviour {
		public List<GameObject>ListCheckPointGameObject=new List<GameObject>();
		public int index=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetKeyDown (KeyCode.N)) {
						ListCheckPointGameObject.RemoveAt (index);
				}
			
		}
}