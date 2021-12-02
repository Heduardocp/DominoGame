using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using CodeMonkey.Utils;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;
using System;

public class UI_LoginRegister : MonoBehaviour
{
    [SerializeField]
    private GameObject _registerComponent;
    [SerializeField]
    private GameObject _loginComponent;

    public void ShowLogin()
    {
        _registerComponent.SetActive(false);
        _loginComponent.SetActive(true);

    }
    public void ShowRegister()
    {
        _registerComponent.SetActive(true);
        _loginComponent.SetActive(false);
    }
}
