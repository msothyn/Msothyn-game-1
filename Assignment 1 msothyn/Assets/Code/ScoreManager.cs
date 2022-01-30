using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance;
    public Text scoreText;
    public Text purpleScore;
    public Text blueScore;
    public Text greenScore;



    int purple = 0;
    int green = 0;
    int blue = 0;
    int score = 0;
    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start() {
        purpleScore.text = "Purple: " + purple.ToString() + " POINTS";
        greenScore.text = "Green: " + green.ToString() + " POINTS";
        blueScore.text = "Blue: " + blue.ToString() + " POINTS";
        scoreText.text = "Score: " + blue.ToString() + " POINTS";

    }

    public void AddPurplePoint() {
        purple += 1;
        purpleScore.text = "Purple: " + purple.ToString() + " POINTS";
    }

    public void AddGreenPoint() {
        green += 3;
        greenScore.text = "Green: " + green.ToString() + " POINTS";
    }

    public void AddBluePoint() {

        blue += 2;
        blueScore.text = "Blue: " + blue.ToString() + " POINTS";
    }

    public void sumOfPoints() {

        score = purple + green + blue;
        scoreText.text = "Score: " + score.ToString() + " Points";
        if (score == 18) {
            scoreText.text = "Game Over";
            Invoke("Restart", 6f);
        }
    }
    public void Restart() {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
