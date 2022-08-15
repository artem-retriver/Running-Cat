using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    public void Initialize(GameManager gameManager)
    {
        playerController.Initialize(gameManager);
    }
}
