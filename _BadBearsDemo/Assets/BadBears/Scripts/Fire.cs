using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

public GameObject[] novelo = new GameObject[3];
public float start_timer;
public float[] timer = new float[3];
public bool[] status = new bool[3];
public float timer_destroy;
public float initXPosNovelos;

// Use this for initialization
void Start () {
	initXPosNovelos = novelo[0].transform.position.x;
        for(int i=0; i<3; ++i){
		timer[i] = start_timer;
		status[i] = false;
		novelo[i].SetActive(false);
	}
}

void Update (){
	destroyFire();
}


void destroyFire(){
for(int i = 0; i<3; ++i){
    if(status[i]){
    timer[i] -= Time.deltaTime * timer_destroy;
         if(timer[i] < 0){
          novelo[i].SetActive(false);
          status[i] = false;
          timer[i] = start_timer;
                     }     
    }
}
}
        public void onBtnFire(int button_pressed){
        processFire(button_pressed);
}
       void processFire(int button){
       novelo[button].transform.position = new Vector3(initXPosNovelos,novelo[button].transform.position.y,novelo[button].transform.position.z);
       novelo[button].SetActive(true);
       status[button] = true;
       }
       


}

