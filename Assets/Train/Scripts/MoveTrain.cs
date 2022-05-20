using UnityEngine;
using System.Collections;

public class MoveTrain : MonoBehaviour {
		public float speed = 10f;

		public int numerLinia = 0,indexArTwo=0;
		public PosArray posArray;	
		public GameObject checkPoint;
		public ListCheckPoint listScriptChekPoints;
	// Use this for initialization
	void Start () {
				checkPoint = GameObject.Find("CreateCheckPoint");
				listScriptChekPoints = checkPoint.GetComponent<ListCheckPoint>();
				posArray = checkPoint.GetComponent<PosArray>();
	}
		private bool forward=true,Back=false;
		public int  colCheckpoint=0; 
	// Update is called once per frame
	void Update () {
				for (int i = 0; i < posArray.colIndex.Count; i++) {
						if (numerLinia == i) {
								colCheckpoint = posArray.colIndex [i];
						}
				}
		
				if (posArray.colIndex.Count>0) {
						MoveTowardsTarget(listScriptChekPoints.ListCheckPointGameObject[posArray.SaveIndex [numerLinia, indexArTwo]].transform.position);
						RotateTowardsTarget(listScriptChekPoints.ListCheckPointGameObject[posArray.SaveIndex [numerLinia, indexArTwo]].transform.position);

	if (Back & transform.position.x > listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia,indexArTwo]].transform.position.x &
								transform.position.x < listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.x + 1 &
						  transform.position.y > listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.y &
						  transform.position.y < listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.y + 1
						  |
						  transform.position.y == listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.y &
						  transform.position.x == listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.x & Back) {
								indexArTwo -= 1;


						}
						if (forward & transform.position.x > listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.x & 
								transform.position.x < listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.x + 1 &
						  transform.position.y > listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.y &
						  transform.position.y < listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.y + 1 |
						  transform.position.y == listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.y &
						  transform.position.x == listScriptChekPoints.ListCheckPointGameObject [posArray.SaveIndex [numerLinia, indexArTwo]].transform.position.x & forward) {
								indexArTwo += 1;

						}

						if (indexArTwo == colCheckpoint & forward) {
								forward = false;
								Back = true;		
								indexArTwo -= 1;
						}
						if (indexArTwo == 0 & Back) {
								forward = true;
								Back = false; 							


						}
				}
	}
		private void MoveTowardsTarget(Vector2 target)
		{    
					transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

		}

		private void RotateTowardsTarget(Vector2 target)
		{
				Vector2 direction =target-(Vector2)transform.position.normalized;

				var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
				var offset = 90f;
				transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
		}
}
