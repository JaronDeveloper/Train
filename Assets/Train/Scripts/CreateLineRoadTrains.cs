using UnityEngine;
using System.Collections;

public class CreateLineRoadTrains : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		bool stop=true;
		public	int a=0,b=0;
		public float tes = 0;
		private float posX;
		public GameObject TrainRoadX,TrainRoadY;//железная дорога
		public PosArray posArray;//хранить во себе позицие чек поинт
	// Update iотs called once per frame
	void Update () {
				if (posArray.posX.Count > 1&stop) {
						if (b == a) {
								//tes = posArray.posX [a];
								if (posArray.posX [posArray.index - 1] == posArray.posX [posArray.index - 2]) {
										Instantiate (TrainRoadY, new Vector3 (1000, 1000, -0.1f), Quaternion.identity);
										stop = false;
								}
								if (posArray.posY [posArray.index - 1] == posArray.posY [posArray.index - 2]) {
										Instantiate (TrainRoadX, new Vector3 (1000, 1000, -0.1f), Quaternion.identity);
										stop = false;
								}
						}
				}
						if (Input.GetKeyDown (KeyCode.E)) {
								b += 1;
						stop = true;

						}
				if (Input.GetKeyDown (KeyCode.Q)) {
								a += 1;
				
						
				}
	
}
}
