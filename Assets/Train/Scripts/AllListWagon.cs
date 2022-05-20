using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AllListWagon : MonoBehaviour {
		public List<GameObject>AllWagon=new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				for (int i = 0; i < AllWagon.Count; i++) {
						Debug.Log (i+"AllWagon");
						//AllWagon.RemoveAt (0);
				}
			

	}
}
