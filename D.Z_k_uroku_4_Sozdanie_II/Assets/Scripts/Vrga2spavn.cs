using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vrga2spavn: MonoBehaviour
{
    [SerializeField]
    private GameObject _vrag2;

    [SerializeField]
    private Transform _spawnPoint;
    void Start()
    {
        Instantiate(_vrag2, _spawnPoint.position, Quaternion.identity);
    }


    void Update()
    {

    }
}
