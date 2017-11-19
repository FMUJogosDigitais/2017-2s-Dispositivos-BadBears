using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TrocarCena : MonoBehaviour {

	public void MudarCena (string nomeDaCena) {
        SceneManager.LoadScene(nomeDaCena);

    }

        public void CloseGame () {
            Application.Quit();
                                 }

}   
