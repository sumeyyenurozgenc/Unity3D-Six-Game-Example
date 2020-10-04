using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionforGameOver : MonoBehaviour
{
    public GameObject tryAgainPanel;
    private FollowHex hex;
    private void Start()
    {
        tryAgainPanel.SetActive(false);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            tryAgainPanel.SetActive(true);
            GameController.currentState = GameController.GameStates.GameOver;
        }
    }
}
