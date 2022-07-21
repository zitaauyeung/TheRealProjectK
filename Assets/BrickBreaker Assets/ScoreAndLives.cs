using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreAndLives : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 3;
    public Text textScore;
    public Text textLives;
    public static int currLvl = 1;
    int[] blocksToBreak = {21, 21, 8};
    public static int blocksBroken = 0;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        textScore.text = "Score: " + score.ToString();
        textLives.text = "Lives: " + lives.ToString();
        if(lives < 1){
            SceneManager.LoadScene("GameOver");
        }
        if(blocksBroken == blocksToBreak[currLvl]){
            currLvl++;
            blocksBroken = 0;
            SceneManager.LoadScene(currLvl);
        }
    }
}
    