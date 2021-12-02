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

public class PlayFabRegister : MonoBehaviour
{
    
    private TMP_InputField emailField;
    private TMP_InputField usernameField;
    private TMP_InputField passwordField;
    [SerializeField]
    private UnityEvent unityEvent;

    private bool loading;
    // Start is called before the first frame update
    private void Awake()
    {
   
        emailField = transform.Find("Email").GetComponentInChildren<TMP_InputField>();
        usernameField = transform.Find("Username").GetComponentInChildren<TMP_InputField>();
        passwordField = transform.Find("Password").GetComponentInChildren<TMP_InputField>();
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToLogin()
    {
        unityEvent.Invoke();
    }
    public void RegisterAction()
    {
        if (loading == false)
        {

        loading = true;
        var request = new RegisterPlayFabUserRequest { Email = emailField.text, Password = passwordField.text, Username = usernameField.text, RequireBothUsernameAndEmail = true };
        PlayFabClientAPI.RegisterPlayFabUser(request, SuccessRegister, ErrorRegister);
        }
    }

    private void ErrorRegister(PlayFabError obj)
    {
        loading = false;
        Debug.Log(obj);
    }

    private void SuccessRegister(RegisterPlayFabUserResult obj)
    {
        loading = false;
        Debug.Log(obj);
    }

   
}
