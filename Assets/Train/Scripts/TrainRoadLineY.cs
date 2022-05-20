using UnityEngine;
using System.Collections;

public class TrainRoadLineY : MonoBehaviour {
		public CreateCheckPoint createCheckPointSript;
		public GameObject createCheckPointGameobject;
	// Use this for initialization
	void Start () {
				createCheckPointGameobject = GameObject.Find("CreateCheckPoint");
				createCheckPointSript = createCheckPointGameobject.GetComponent<CreateCheckPoint>();
				pos = createCheckPointSript.posArray.posY [createCheckPointSript.posArray.index-1] / 2 + createCheckPointSript.posArray.posY [createCheckPointSript.posArray.index-2] / 2;

				transform.position = new Vector3 (createCheckPointSript.posArray.posX [createCheckPointSript.posArray.index-1], pos, -0.1f);
	}
		Vector3 scaleVector;
		private float t=0.0f;
		private	bool startScale=true;
		private float pos;
	// Update is called once per frame
		void Update () {
				if (startScale) {	
								

										transform.localScale =	new Vector3 (0.1f, scaleVector.y, 0.1f);
										t += 0.1f;
										scaleVector.y = t;
								
						
				} else {
						Destroy(GetComponent<TrainRoadLineY>());

				}
	
	}
		void OnTriggerEnter(Collider other){
				if(other.tag=="CheckPoint"){
						startScale = false;
				}

		}
}
