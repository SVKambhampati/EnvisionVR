using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenesThree : MonoBehaviour
{
    public void GoToSceneFour()
    {
        SceneManager.LoadScene("Geography Wonders");
    }
}
