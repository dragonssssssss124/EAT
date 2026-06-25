using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEVSCRIPTS : MonoBehaviour
{
    private void Update()
    {
        if ((Input.GetKey(KeyCode.M)) && (Input.GetKey(KeyCode.O)) && (Input.GetKey(KeyCode.N)) && (Input.GetKey(KeyCode.Y)) && (Input.GetKey(KeyCode.E)))
        {
            SceneManager.LoadScene(11);
        }
    }
}
