using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public Text currentScoreText;
    public Text bestScoreText;
    private int score;
    private int best;
    public static GameStates currentState;

    public enum GameStates
    {
        Start, GameOver
    }

    private void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        Best = PlayerPrefs.GetInt("BestScore", Best);
    }

    private int Score
    {
        get { return score; }
        set { score = value; currentScoreText.text = value.ToString(); }
    }

    private int Best
    {
        get { return best; }
        set { best = value; bestScoreText.text = value.ToString(); }
    }

    public void IncreaseScore(int scoreNumber)
    {
        Score += scoreNumber;
        if (Score > Best)
        {
            Best = Score;
            PlayerPrefs.SetInt("BestScore", Best);
        }
    }
}
