using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayerPosition : MonoBehaviour
{
    [SerializeField] private Vector3Variable _playerPosition;
    [SerializeField] private Transform playerTransform;

    void Update()
    {
        _playerPosition.Value = playerTransform.position;
    }
}
