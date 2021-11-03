﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*몬스터 스폰지점부터 코어까지의 경로를 시각화 시켜준다.*/
public class PathVisualizerManager : MonoBehaviour
{
    public static PathVisualizerManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("PathVisualizerManager can exist only one in a scene!");
            return;
        }
        instance = this;
    }

    public GameObject visualizer_prefab;
    public GameObject board;
    public Transform spawnPoint;
    private Vector3 spawnPosition;
    private GameObject visualizer;

    public void RestartPathVisual()                      //경로 끝에 도착하면 다시 시작
    {
        if (visualizer_prefab != null && board.activeSelf)
        {
            visualizer = Instantiate(visualizer_prefab, GetSpawnPosition(), spawnPoint.rotation);
        }
    }

    
    private Vector3 GetSpawnPosition()
    {
        if (spawnPoint != null)
        {
            spawnPosition.x = spawnPoint.transform.position.x;
            //spawnPosition.y = spawnPoint.transform.position.y;
            spawnPosition.y = spawnPoint.transform.position.y - 0.025f;
            spawnPosition.z = spawnPoint.transform.position.z;
        }
        return spawnPosition;
    }

    public void Hide()
    {
        Destroy(visualizer);
    }
    public void Show()
    {
        Hide();
        RestartPathVisual();
    }
}
   
