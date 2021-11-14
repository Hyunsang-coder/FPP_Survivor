using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;
    [SerializeField] float switchTime = 0.5f;

    void Start()
    {
        SetWeaponActive();
    }


    void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessWeaponInput();
        ProcessScrollWheel();

        if (previousWeapon != currentWeapon)
        {
            Invoke("SetWeaponActive", switchTime);
            //SetWeaponActive();
        }
    }

    private void ProcessScrollWheel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentWeapon >= transform.childCount - 1)
            {
                currentWeapon = 0;
            }
            else
            {
                currentWeapon++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currentWeapon < 0)
            {
                currentWeapon = transform.childCount - 1;
            }
            else
            {
                currentWeapon--;
            }
        }
    }

    void ProcessWeaponInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
    }

    public void SetWeaponActive()
    {
        // ����Ƽ ��ü������ �ڽ� object�� transfrom enumerator�� �����, loop Ƚ���� ���� active ���� ����.
        int weaponIndex = 0;
        foreach (Transform weapon in transform)
        {
            if (currentWeapon == weaponIndex)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }

    }
    
}
