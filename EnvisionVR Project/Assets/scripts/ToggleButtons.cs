using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButtons : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggleGameObj()
    {
        obj.SetActive(!obj.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}




