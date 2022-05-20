using UnityEngine;
using System.Collections;

public class Wagon : MonoBehaviour {
		public GameObject listGameCar;		
	    public float speed = 10f;
		public ListWagon lw;
		public ListTrain listCar;		

		public int CountInt;
		// Use this for initialization
		void Start () {

				listGameCar = GameObject.Find("ListTrain");
				listCar = listGameCar.GetComponent<ListTrain>();
				lw=listCar.listWagon[listCar.numerSriptsMoveCar];
				CountInt = lw.Wagon.Count-1;				

		}		


		void Update () {	
				


		
						if (Vector3.Distance (transform.position, lw.Wagon [CountInt].transform.position) > 1f) {
						MoveTowardsTarget ();
						RotateTowardsTarget ();
						}	

					
		}
		private void MoveTowardsTarget()
		{    
				
				transform.position = Vector2.MoveTowards(transform.position, lw.Wagon[CountInt].transform.position, speed * Time.deltaTime);
		}

		private void RotateTowardsTarget()
		{
				Vector2 direction = ((Vector2)lw.Wagon[CountInt].transform.position - (Vector2)transform.position).normalized;

				var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
				var offset = 90f;
				transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
		}
}
