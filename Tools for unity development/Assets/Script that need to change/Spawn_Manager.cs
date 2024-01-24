using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private float _SpawnTimer = 1f;
    public float _SpawnSpeed = 1f;
    [SerializeField] private float topSpawnSpeed = 10f;

    [Header("Game Objects")]
    [SerializeField] private GameObject _FallEnemy;
    [SerializeField] private GameObject _SlideEnemy;
    [SerializeField] private GameObject _TopEnemy;

    [Header("Number of enemys")]
    public float maxNumberOfEmenys;
    public float maxSlide;
    public float maxtop;
    private Player_Controller _Player;
    private Wave_Manager wave_Manager;


    void Start()
    {
        _Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        wave_Manager = GameObject.FindGameObjectWithTag("Wave_Manager").GetComponent<Wave_Manager>();
    }


    void Update()
    {

        if(_Player != null)
        {
         if (Time.time > _SpawnTimer && GameObject.FindGameObjectsWithTag("Enemy").Length < maxNumberOfEmenys)
        {
            _SpawnTimer = Time.time + _SpawnSpeed;

            Instantiate(_FallEnemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);
        }

        if(wave_Manager.numberskilled >= 25 && Time.time > _SpawnTimer)
        {

            _SpawnTimer = Time.time + topSpawnSpeed;

            Instantiate(_TopEnemy, new Vector3(Random.Range(-9.5f, 10f), 8, 0), Quaternion.identity);

        }
        }
        else
        {
            Debug.Log("stoped spawning");

            maxNumberOfEmenys = 0;
            maxSlide = 0;
            maxtop= 0;

        }

    }
}
