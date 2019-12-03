using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEnabler : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    private bool enabled = true;
    void Start()
    {
        Camera1.SetActive(enabled);
        Camera2.SetActive(!enabled);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            enabled = !enabled;
            Camera1.SetActive(enabled);
            Camera2.SetActive(!enabled);
        }
    }
}
