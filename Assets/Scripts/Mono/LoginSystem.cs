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
public class LoginSystem : MonoBehaviour
{
    private TMP_InputField usernameField;
    private TMP_InputField passwordField;
    private PlayFabAuthenticationContext authContext;
    [SerializeField]
    private UnityEvent unityEvent;

    private bool loading;
    // Start is called before the first frame update
    private void Awake()
    {

        usernameField = transform.Find("Username").GetComponentInChildren<TMP_InputField>();
        usernameField.text = "hectorcruz92";
        passwordField = transform.Find("Password").GetComponentInChildren<TMP_InputField>();
        passwordField.text = "123456";

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GoToRegister()
    {
        unityEvent.Invoke();
    }


    public void LoginAction()
    {
        if (loading == false)
        {

            loading = true;
            var request = new LoginWithPlayFabRequest { Password = passwordField.text, Username = usernameField.text, };
            PlayFabClientAPI.LoginWithPlayFab(request, SuccessLogin, ErrorLogin);
        }
    }

    private void ErrorLogin(PlayFabError obj)
    {
        loading = false;
        Debug.Log(obj);
    }

    private void SuccessLogin(LoginResult obj)
    {
        var id = obj.PlayFabId;
        authContext = obj.AuthenticationContext;
           loading = false;
        Debug.Log(id);
        
    }
}
