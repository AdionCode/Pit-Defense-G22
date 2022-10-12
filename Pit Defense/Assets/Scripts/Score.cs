using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int HighScore;
    public GameObject text;

    [SerializeField] TMP_Text textPH2;

    // Start is called before the first frame update
    void Start()
    {
        HighScore = 0;
        textPH2 = text.GetComponent<TMP_Text>();
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
        textPH2.text = HighScore.ToString();
    }
}
