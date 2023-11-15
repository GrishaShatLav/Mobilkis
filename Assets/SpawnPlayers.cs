using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        Vector2 Position = new Vector2(-0.52f,-2.57f);
        PhotonNetwork.Instantiate(playerPrefab.name, Position, Quaternion.identity);
    }
}
