using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int _scorePlayer1 = 0;
    private int _scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalsToWin;

    // Update is called once per frame
    void Update()
    {
        if (this._scorePlayer1 >= this.goalsToWin || this._scorePlayer2 >= goalsToWin){
            Debug.Log("Game Won");
            SceneManager.LoadScene("GameOver");
        }
    }

    private void FixedUpdate()
    {
        Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this._scorePlayer1.ToString();
        
        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this._scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this._scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this._scorePlayer2++;
    }
}
