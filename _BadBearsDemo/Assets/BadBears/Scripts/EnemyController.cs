using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public GameObject player;
	public GameObject restart;
	public GameObject close;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")){
			player.SetActive (false);
			restart.SetActive (true);
			close.SetActive (true);
		}

		if (other.gameObject.CompareTag("Novelo")){
			gameObject.SetActive (false);
		}
	}
}

