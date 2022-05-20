using UnityEngine;
using System.Collections;

public class CreateCheckPoint : MonoBehaviour {
		public PosArray posArray;
		public GameObject prefabChekpoint;
		public int indexLine,indexaArTwy,index;
		private int namberCheckPoint;
	// Use this for initialization
	void Start () {
	
	}
		private bool startCheckPoint=true,stopCheckPoint=false;
	// Update is called once per frame
	void Update () {
				if(stopCheckPoint){
						if (Input.GetKeyDown (KeyCode.E)) {
								namberCheckPoint += 1;
								if (posArray.posX.Count > 0) {
										index += 1;
								}
								if (indexLine == 0) {
										posArray.index += 1;
								} else {
										if (indexaArTwy == 2) {
												posArray.index += 2;

										} else if (indexaArTwy > 2) {
												posArray.index += 1;

										}
								}
								stopCheckPoint = false;
								startCheckPoint = true;
						}
				}
				if (Input.GetKeyDown (KeyCode.T)) {
						indexLine += 1;
						posArray.colIndex.Add (indexaArTwy);
						indexaArTwy = 0;	

				}
				if (startCheckPoint) {
						if (Input.GetKeyDown (KeyCode.Q)) {
							
								if (posArray.posX.Count == 0) {
										Instantiate (prefabChekpoint, new Vector3 (0, 0, 0), Quaternion.identity);
								} else {
										Instantiate (prefabChekpoint, new Vector3 (posArray.posX [index], posArray.posY [index], 0), Quaternion.identity);
									
								}
								indexaArTwy += 1;
								startCheckPoint = false;
								stopCheckPoint = true;
						}
					
				}
				posArray.SaveIndex [indexLine,indexaArTwy] = namberCheckPoint;
	}
}
