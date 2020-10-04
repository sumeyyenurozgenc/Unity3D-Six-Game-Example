using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHex : MonoBehaviour
{
    public Transform hex;
    public GameObject[] shapes;

    private void Awake()
    {
        InstantiateCubes();
        GameController.currentState = GameController.GameStates.Start;
    }

    private void FixedUpdate()
    {
        if (GameController.currentState != GameController.GameStates.GameOver)
        {
            transform.position = new Vector3(transform.position.x, hex.position.y, transform.position.z);
        }
    }
  
    private void InstantiateCubes()
    {
        float colorRed = 0;
        float colorGreen = 0;
        float colorBlue = 0;
        float yAxisPosition=0;
        for (int i = 0; i < shapes.Length; i++)
        {
            GameObject cube = Instantiate(shapes[i]) as GameObject;
            cube.transform.position = new Vector3(0, shapes[i].transform.position.y + yAxisPosition, 0);
           for (int j = 0; j < cube.transform.childCount; j++)
            {
                cube.transform.GetChild(j).GetComponent<SpriteRenderer>().color = new Color(colorRed, colorGreen, 1-colorBlue, 1f);
                colorRed += 0.02f;
                colorGreen-= 0.01f;
                colorBlue+= 0.01f;
            }
            yAxisPosition += (-5);

        }
    }
}
