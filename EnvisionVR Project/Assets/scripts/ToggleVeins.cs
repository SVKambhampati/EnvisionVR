using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVeins : MonoBehaviour
{
    public GameObject veins;

    // Start is called before the first frame update
    void Start()
    {
        if (veins.activeInHierarchy == false)
        {
            veins.SetActive(true);
        }
        else
        {
            veins.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
