using UnityEngine;
using System.Collections;

public class TrainRoadLineX : MonoBehaviour {
		Vector3 scaleVector;

		public CreateCheckPoint createCheckPointSript;
		public GameObject createCheckPointGameobject;
		// Use this for initialization
		void Start () {
				createCheckPointGameobject = GameObject.Find("CreateCheckPoint");
				createCheckPointSript = createCheckPointGameobject.GetComponent<CreateCheckPoint>();
				pos = createCheckPointSript.posArray.posX [createCheckPointSript.posArray.index-1] / 2 + createCheckPointSript.posArray.posX [createCheckPointSript.posArray.index-2] / 2;

				transform.position = new Vector3 (pos, createCheckPointSript.posArray.posY [createCheckPointSript.posArray.index-1], -0.1f);

		}
		private float t=0.0f;
		private	bool startScale=true;
		private float pos;
		// Update is called once per frame
		void Update () {
				if (startScale) {	
						if (createCheckPointSript.posArray.posX.Count > 1) {


								transform.localScale =	new Vector3 (scaleVector.x, 0.1f, 0.1f);
								t += 0.1f;
								scaleVector.x = t;

						}
				} else {
						Destroy(GetComponent<TrainRoadLineX>());

				}

		}
		void OnTriggerEnter(Collider other){
				if(other.tag=="CheckPoint"){
						startScale = false;
				}

		}


}
