using UnityEngine;
using System.Collections;

public class playerClick : MonoBehaviour {
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Text m_scoreText;
    public int score;
    public int scoreIncrement;

	// Use this for initialization
	void Start () {
        m_scoreText.text = "Kappas: " + score;
        score = 0;
        scoreIncrement = 1;
        image = GetComponent<UnityEngine.UI.Image>();
        image.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        m_scoreText.text = "Kappas: " + score;
	}

	public void AddScore()
    {
        score += scoreIncrement;
       //image.enabled;
       //if (Random.Range(0,17) == 17)
       // {
       //     image.enabled = true;
       // }
    }

   
}
