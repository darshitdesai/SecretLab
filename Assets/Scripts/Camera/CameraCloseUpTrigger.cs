using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraCloseUpTrigger : MonoBehaviour {

    public Camera mainCamera;
    public Camera closeUpCamera;

    // Defined by unity
    void OnTriggerEnter2D(Collider2D other)
    {
        // If the other object is a player, then do something
        if(other.gameObject.tag == "Robot")
        {
            mainCamera.enabled = false;
            closeUpCamera.enabled = true;
			SceneManager.LoadScene ("Temp");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Robot")
        {
            closeUpCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }
}
