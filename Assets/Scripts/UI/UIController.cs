using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

namespace NSLS.Game.UI
{
  public class UIController : MonoBehaviour
  {
    public Transform spawnAnchor;

    void OnGUI()
    {
      GUILayout.BeginArea(new Rect(10, 10, 300, 300));
      if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
      {
        StartButtons();
      }
      else
      {
        StatusLabels();
        StopButtons();
        //SubmitNewPosition();
      }

      GUILayout.EndArea();
    }

    void StartButtons()
    {
      // FIXME: move logic from the UI, leave only events

      if (GUILayout.Button("Host")) NetworkManager.Singleton.StartHost(spawnAnchor.position, spawnAnchor.rotation);
      if (GUILayout.Button("Client")) NetworkManager.Singleton.StartClient();
      if (GUILayout.Button("Server")) NetworkManager.Singleton.StartServer();
    }

    void StopButtons()
    {
      var mode = NetworkManager.Singleton.IsHost ?
          "Host" : NetworkManager.Singleton.IsServer ? "Server" : "Client";

      if (NetworkManager.Singleton.IsHost && GUILayout.Button("Stop server")) NetworkManager.Singleton.StopServer();
      if (!NetworkManager.Singleton.IsHost && GUILayout.Button("Leave")) NetworkManager.Singleton.StopClient();
      // FIXME: don't do UI if only running server

    }
    void StatusLabels()
    {
      var mode = NetworkManager.Singleton.IsHost ?
          "Host" : NetworkManager.Singleton.IsServer ? "Server" : "Client";

      GUILayout.Label("Transport: " +
          NetworkManager.Singleton.NetworkConfig.NetworkTransport.GetType().Name);
      GUILayout.Label("Mode: " + mode);
    }

    // static void SubmitNewPosition()
    // {
    //   if (GUILayout.Button(NetworkManager.Singleton.IsServer ? "Move" : "Request Position Change"))
    //   {
    //     if (NetworkManager.Singleton.ConnectedClients.TryGetValue(NetworkManager.Singleton.LocalClientId,
    //         out var networkedClient))
    //     {
    //       var player = networkedClient.PlayerObject.GetComponent<Cha>();

    //       if (player)
    //       {
    //         player.Move();
    //       }
    //     }
    //   }
    // }
  }
}
