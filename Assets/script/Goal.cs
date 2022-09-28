using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text myScoreText;
    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter(Collision other)
    {
      
        other.transform.position = Vector3.zero;

        Score += 1;
        //Score = Score + 1;
        ///Score++;

        myScoreText.text = Score.ToString();

        if(Score == 10)
        {
            SceneManager.LoadScene("PongScene");
        }
    }
}
