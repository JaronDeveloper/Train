using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class ListTrain : MonoBehaviour {
		public GameObject[] car=new GameObject[10];
		public int index = 0;
		public MoveTrain[] moveCar=new MoveTrain[10];
		public ListWagon[] listWagon=new ListWagon[99];
		public AllListWagon allListWagon;
		public Text TextNumerCar,TextLineSmena;
		public int numerSriptsMoveCar=0;
	// Use this for initialization
	void Start () {
					


		}
	
	// Update is called once per frame
	void Update () {
				
				if (car [index] != null) {
						moveCar[index]=  car [index] .GetComponent<MoveTrain>();	
						listWagon[index]=  car [index] .GetComponent<ListWagon>();		

								index += 1;


				}	
				CountallListWagon = allListWagon.AllWagon.Count-1;
				if (allListWagon.AllWagon.Count>0) {

						listWagon [numerSriptsMoveCar].Wagon.Add (allListWagon.AllWagon [CountallListWagon]);
						allListWagon.AllWagon.RemoveAt (CountallListWagon);
				}

	}
		public int CountallListWagon=0;
	
		public void PlusNumerCar(){
				if (index > numerSriptsMoveCar+1) {
						numerSriptsMoveCar += 1;
				}
				TextLineSmena.text ="0";				

				TextNumerCar.text =""+ numerSriptsMoveCar;
		}

		public void MinusNumerCar(){
				if (numerSriptsMoveCar > 0) {
						numerSriptsMoveCar -= 1;
				}
				TextLineSmena.text ="0";				

				TextNumerCar.text =""+ numerSriptsMoveCar;

		}
		public void PlusLineSmena(){
				car [numerSriptsMoveCar].transform.position = new Vector2 (0, 0);
				if (moveCar[numerSriptsMoveCar].posArray.colIndex.Count > moveCar [numerSriptsMoveCar].numerLinia+1) {
						moveCar [numerSriptsMoveCar].numerLinia += 1;
				}
				moveCar [numerSriptsMoveCar].indexArTwo = 0;
				TextLineSmena.text =""+ moveCar [numerSriptsMoveCar].numerLinia;				

		}
		public void MinusLineSmena(){
				car [numerSriptsMoveCar].transform.position = new Vector2 (0, 0);
				if (moveCar [numerSriptsMoveCar].numerLinia > 0) {
						moveCar [numerSriptsMoveCar].numerLinia -= 1;
				}
				moveCar [numerSriptsMoveCar].indexArTwo = 0;
				TextLineSmena.text =""+ moveCar [numerSriptsMoveCar].numerLinia;


		}
}