using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    private Animator anim;
    private MoveController moveController;
    public AudioSource sourceFishBone;
    public AudioSource sourceSmash;

    private bool isAlive = false;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
        moveController = GetComponent<MoveController>();
        anim.Play("Cat_Idle1");
        IsAlive();
    }

    public void Update()
    {
        if (isAlive == true)
        {
            moveController.InputHandler();
            moveController.Movebale();
            
        }
        else  
            return;
    }

    public void FixedUpdate()
    {
        if (isAlive == true)
        {
            moveController.Move();
        }
        else
        {
            moveController.UnMove();
        }
            return;
    }

    public void IsAlive()
    {
        StartCoroutine(WaitGameCoroutine());
    }

    public void Initialize(GameManager gameManager)
    {
        _gameManager = gameManager;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Fish fish))
        {
            sourceFishBone.Play();
            _gameManager.IncreaseCoins();
            other.gameObject.SetActive(false);
        }

        if(other.TryGetComponent(out Obstacle obstacle))
        {
            sourceSmash.Play();
            Died();
            StartCoroutine(WaitLoseCoroutine());
        }
    }

    private void Died()
    {
        isAlive = false;
        anim.Play("Death_1");
    }

    private IEnumerator WaitLoseCoroutine()
    {
        yield return new WaitForSeconds(3f);
        _gameManager.LoseGame();
    }

    private IEnumerator WaitGameCoroutine()
    {
        yield return new WaitForSeconds(3f);
        isAlive = true;
        anim.Play("runStart");
    }
}
