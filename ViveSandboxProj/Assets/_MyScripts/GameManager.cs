using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    private float health;

    public Text healthText;

	// Use this for initialization
	void Start () {
        health = 100;

        updateHealthText();

        if (gm == null)
            gm = this.gameObject.GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeHealth(int modifier)
    {
        health += modifier;

        updateHealthText();
    }

    void updateHealthText()
    {
        if(healthText != null)
        {
            healthText.text = "" + health;
        }
    }
}
