using System;
using PlayFab;
using PlayFab.ClientModels;
using PlayFab.Party;
using UnityEngine;
using UnityEngine.UI;

public class DemoScript : MonoBehaviour
{
    public InputField networkIdTextBox;

    public Text output;

    private void Start()
    {
    }

    private void Update()
    {
    }

    public void CreateAndJoinToNetwork()
    {
    }

    public void JoinNetwork()
    {
    }

    private void OnDataMessageReceived(object sender, PlayFabPlayer from, byte[] buffer)
    {
    }

    private void OnDataMessageNoCopyReceived(object sender, PlayFabPlayer from, IntPtr buffer, uint bufferSize)
    {
    }

    private void OnNetworkJoined(object sender, string networkId)
    {
    }

    private void OnLoginSuccess(LoginResult result)
    {
    }

    private void OnLoginFailure(PlayFabError error)
    {
    }
}