using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Manager : MonoBehaviour
{
[Header("Spawn timers")]
[SerializeField] private float _SpawnTimer = 10f;
[SerializeField] private float _SpawnSpeed = 1f;

[Header("Game objects")]
[SerializeField] private GameObject _HealthPower;
[SerializeField] private GameObject _SpeedPower;
[SerializeField] private GameObject _TriplePower;

public GameObject[] _Powerups;

[Header("Spawn limit")]
public float numberOfPowerUps;

[Header("Scripts")]
private Player_Controller _Player;

public float _allpowerups;

    void Start()
    {
        
        _Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();

        _allpowerups = GameObject.FindGameObjectsWithTag("Health_Power").Length + GameObject.FindGameObjectsWithTag("Speed_Power").Length + GameObject.FindGameObjectsWithTag("Tripple_Power").Length;
    }

    void Update()
    {
        
        if(_Player != null)
        {

            if(Time.time > _SpawnTimer && _allpowerups < numberOfPowerUps)
            {
                int powerIndex = Random.Range(0,_Powerups.Length);

                _SpawnTimer = Time.time + _SpawnSpeed;
                Instantiate(_Powerups[powerIndex], new Vector3(Random.Range(-9.5f ,10f), 8, 0), _Powerups[powerIndex].transform.rotation);

            }

        }
         else
        {

            numberOfPowerUps = 0;

        }

    }
}
