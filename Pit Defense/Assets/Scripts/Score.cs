using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int HighScore;
    public GameObject text;
    [SerializeField] Text textPH;

    // Start is called before the first frame update
    void Start()
    {
        HighScore = 0;
        textPH = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        addPointToUI();
    }

    public void addScore(int point)
    {
        HighScore += point;
        
    }

    public void addPointToUI()
    {
        textPH.text = HighScore.ToString();
    }
}
