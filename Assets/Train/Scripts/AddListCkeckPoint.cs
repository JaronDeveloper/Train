using UnityEngine;
using System.Collections;

public class AddListCkeckPoint : MonoBehaviour {
		public ListCheckPoint listScriptChekPoints;		public GameObject checkPoint;
		public PosArray posArray;	

	// Use this for initialization
	void Start () {
				checkPoint = GameObject.Find("CreateCheckPoint");
				listScriptChekPoints = checkPoint.GetComponent<ListCheckPoint>();
				posArray = checkPoint.GetComponent<PosArray>();
				listScriptChekPoints.ListCheckPointGameObject.Add (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetKeyDown (KeyCode.Q)) {
				}	
	}
}
