using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTwo : MonoBehaviour
{
    public void GoToSceneThree()
    {
        SceneManager.LoadScene("Physics Phenomena");
    }
}
