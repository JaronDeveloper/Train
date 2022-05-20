using UnityEngine;
using System.Collections;

public class DestroyAllListWagon : MonoBehaviour {
		public AllListWagon allListWagon;
		public GameObject listWagon;
	// Use this for initialization
	void Start () {
				listWagon = GameObject.Find("AllListWagon");
				allListWagon = listWagon.GetComponent<AllListWagon>();
				allListWagon.AllWagon.Add(gameObject);
				Destroy(GetComponent<DestroyAllListWagon>());

	}
	
	
}
