using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    bool isADS = false;
    [SerializeField] Camera fpsCam;
    [SerializeField] float zoomedOUt = 60f;
    [SerializeField] float zoomedIn4x = 20f;
    [SerializeField] float zoomedSensitivity = 0.5f;
    [SerializeField] float normalSensitivity = 2f;
    public RigidbodyFirstPersonController fppController;


    void Start()
    {
        fppController = GetComponent<RigidbodyFirstPersonController>();
    }

    void Update()
    {
        AimDownSights();
    }

    public void AimDownSights()
    {
        if (Input.GetButtonDown("Fire2") && !isADS)
        {
            Debug.Log("4x ADS");
            fpsCam.fieldOfView = zoomedIn4x;
                        
            fppController.mouseLook.XSensitivity = zoomedSensitivity;
            fppController.mouseLook.YSensitivity = zoomedSensitivity;

            isADS = true;
        }

        else if (Input.GetButtonDown("Fire2") && isADS)
        {
            fpsCam.fieldOfView = zoomedOUt;
            
            fppController.mouseLook.XSensitivity = normalSensitivity;
            fppController.mouseLook.YSensitivity = normalSensitivity;
            
            isADS = false;

        }
    }
}