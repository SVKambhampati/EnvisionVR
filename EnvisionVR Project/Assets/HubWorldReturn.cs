using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubWorldReturn : MonoBehaviour
{
    public void GoToHubWorld()
    {
        SceneManager.LoadScene("Hub World");
    }
}
