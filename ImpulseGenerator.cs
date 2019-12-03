using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ImpulseGenerator : MonoBehaviour
{

    public CinemachineImpulseSource impulseSource;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            impulseSource.GenerateImpulse();
        }
    }

}
