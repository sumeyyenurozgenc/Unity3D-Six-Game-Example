using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBoom : MonoBehaviour
{
    public ParticleSystem ps_bomb;

    private void OnMouseDown()
    {
        if (GameController.currentState != GameController.GameStates.GameOver)
        {
            var main = ps_bomb.main;
            main.startColor = gameObject.GetComponent<SpriteRenderer>().color;
            Destroy(gameObject);
            Instantiate(ps_bomb, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            GameController.Instance.IncreaseScore(5);
        }
    }
}
