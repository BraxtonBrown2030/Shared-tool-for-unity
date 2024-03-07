using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
[Header("Health")]
public int _Health = 3;

[Header("Movment")]
public float _Speed;
[Header("Player Combat")]
[SerializeField] private float attackSpeed = 1f;
[SerializeField] private float lastAttackTime = 0.7f;
public int _Damage;
[SerializeField] GameObject laser;
[SerializeField] GameObject tripleShot;
public GameObject[] _player;
public bool istrippleshot = false;
[SerializeField]private float tsCooldown = -0.5f;
[SerializeField]private float lastTSpower = 3f;


public Slider slider;
public Timer pTimer;


public int shotcooldown = 7;


    void Start()
    {
        
        pTimer = GameObject.FindGameObjectWithTag("Power Timer").GetComponent<Timer>();

    }


    void Update()
    {
        Movment();

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > attackSpeed)
        {
            Attack();
        }
        
        //Debug.Log(istrippleshot);
    }

    public void TakeDamage()
    {

        _Health -= 1;

        if(_Health < 1)
        {
            Destroy(this.gameObject);

        }

    }

    void Movment()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * _Speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * _Speed * Time.deltaTime);

        if(transform.position.y >= 6)
         {
             transform.position = new Vector3(transform.position.x,6,0);
         }
        else if(transform.position.y <= -3.8f)
         {
             transform.position = new Vector3(transform.position.x, -3.8f, 0);
         }

        if(transform.position.x >= 11)
         {
             transform.position = new Vector3(-11,transform.position.y,0);
         }
        else if (transform.position.x <=-11)
         {
             transform.position = new Vector3(11,transform.position.y,0);
         }

    }

    void Attack()
    {
        attackSpeed = Time.time + lastAttackTime;


        if(istrippleshot == false)
        {

         Instantiate(laser, transform.position + new Vector3(0,0.8f,0), Quaternion.identity);

        }
        else if(istrippleshot == true)
        {

         Instantiate(tripleShot, transform.position + new Vector3(0,1.3f,0), Quaternion.identity);

        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Enemy_Laser")
        {

            Destroy(other.gameObject);

        }

        if(other.tag == "Tripple_Power" && Time.time > tsCooldown)
        {

            tsCooldown = Time.time + lastTSpower;
            istrippleshot = true;
            StartCoroutine(TripleShotCooldownRun());
            pTimer.StartCountDown();
            Destroy(other.gameObject);
            

        }

        if(other.tag == "Health_Power")
        {

            _Health += 2;
            Destroy(other.gameObject);
        }

        if(other.tag == "Speed_Power")
        {

            _Speed = 5;
            StartCoroutine(SpeedPowerActive());
            pTimer.StartCountDown();
            Destroy(other.gameObject);

        }


    }
    

    public IEnumerator TripleShotCooldownRun()
    {

        yield return new WaitForSeconds(7.0f);
        istrippleshot = false;

    }

    IEnumerator SpeedPowerActive()
    {

        yield return new WaitForSeconds(5.0f);
        _Speed = 5;

    }

}