using UnityEngine;
using System.Collections;

public class DestroyTrain : MonoBehaviour {
		public GameObject Car;
		public ListTrain listCarSripts;
		public GameObject clonelist;
	// Use this for initialization
	void Start () {

				clonelist = GameObject.Find("ListTrain");
				listCarSripts=  clonelist.GetComponent<ListTrain>();
				listCarSripts.car [listCarSripts.index] = Car;
				Destroy(GetComponent<DestroyTrain>());
	}
	
	// Update is called once per frame
	void Update () {
			


	}
}
