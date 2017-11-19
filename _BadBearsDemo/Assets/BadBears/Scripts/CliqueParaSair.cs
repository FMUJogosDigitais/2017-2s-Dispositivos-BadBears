using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliqueParaSair : MonoBehaviour {

    public void Sair()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
