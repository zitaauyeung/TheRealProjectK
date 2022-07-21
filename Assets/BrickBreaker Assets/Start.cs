using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public void No (){
        SceneManager.LoadScene("Level1");
        ScoreAndLives.lives = 3;
        ScoreAndLives.score = 0;
        ScoreAndLives.currLvl = 1;
    }
}
