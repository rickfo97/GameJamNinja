using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager gm;
    private float score;
    private float health;
    public Text scoreText;
    public Text healthText;

  


    

    // Use this for initialization
    void Start () {
        health = 100;
        score = 0;
        updateHealthText();

        if (gm == null)
            gm = this.gameObject.GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void changeScore(int modifier1)
    {
        score += modifier1;
        

    }


    public void changeHealth(int modifier)
    {
        health += modifier;

        updateHealthText();
    }

    void updateScoreText()
    {
        if(scoreText != null)
        {
            scoreText.text = "" + score;
            Debug.log("Score: "+score);
        }

    }

    void updateHealthText()
    {
        if(healthText != null)
        {
            healthText.text = "" + health;
        }
    }
}
