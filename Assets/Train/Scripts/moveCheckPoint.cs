using UnityEngine;
using System.Collections;

public class moveCheckPoint : MonoBehaviour {
		public AddListCkeckPoint addAddListCkeckPoint;
	// Use this for initialization
	void Start () {
	
	}
		private int move=10;
		private bool moveVertical=true,moveHorizintal=true;
	// Update is called once per frame
	void Update () {
				if (moveVertical) {
						if (Input.GetKey (KeyCode.W)) {
								transform.Translate (Vector3.up * move * Time.deltaTime);
								moveHorizintal = false;

						}
						if (Input.GetKey (KeyCode.S)) {
								transform.Translate (Vector3.down * move * Time.deltaTime);
								moveHorizintal = false;

						}
				}
				if (moveHorizintal) {
						if (Input.GetKey (KeyCode.D)) {
								transform.Translate (Vector3.right * move * Time.deltaTime);
								moveVertical = false;

						}
						if (Input.GetKey (KeyCode.A)) {
								transform.Translate (Vector3.left * move * Time.deltaTime);
								moveVertical = false;

						}
				}
				if (Input.GetKeyDown (KeyCode.E)) {
						addAddListCkeckPoint.posArray.posX.Add (gameObject.transform.position.x);
						addAddListCkeckPoint.posArray.posY.Add (gameObject.transform.position.y);
						Destroy(GetComponent<moveCheckPoint>());

				}	
	}
}
