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
    public RigidbodyFirstPersonController fppController;   //접근 안될 때는 name space 때문이니 ctrl + . 로 추가!

    
    void OnDisable()
    {
        ZoomOut();
        Debug.Log("ZoomOut");
    }
    void Start()
    {
        fppController = GetComponentInParent<RigidbodyFirstPersonController>();
    }

    void Update()
    {
        AimDownSights();
    }

    public void AimDownSights()
    {
        if (Input.GetMouseButtonDown(1) && !isADS)
        {
            ZoomIn();
        }

        else if (Input.GetMouseButtonDown(1) && isADS)
        {
            ZoomOut();

        }
    }

    void ZoomIn()
    {
        fpsCam.fieldOfView = zoomedIn4x;

        fppController.mouseLook.XSensitivity = zoomedSensitivity;
        fppController.mouseLook.YSensitivity = zoomedSensitivity;

        isADS = true;
    }

    void ZoomOut()
    {
        fpsCam.fieldOfView = zoomedOUt;

        fppController.mouseLook.XSensitivity = normalSensitivity;
        fppController.mouseLook.YSensitivity = normalSensitivity;

        isADS = false;
    }
}