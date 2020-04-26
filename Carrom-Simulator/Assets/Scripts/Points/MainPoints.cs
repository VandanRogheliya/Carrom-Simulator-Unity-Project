using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainPoints : MonoBehaviour
{
    static public int WhiteScore;
    static public int BlackScore;
    static public int flag;
    static public int QueenFlag;
    static public int WhiteStrikerFlag, BlackStrikerFlag;
    static public int WhiteCoinCounter;
    static public int BlackCoinCounter;
    private string Winner;
    Text score;
    static public int MainPointQueenFlag;


    // Start is called before the first frame update
    void Start()
    {
        WhiteScore = 0;
        BlackScore = 0;
        flag = 1;
        QueenFlag = 0;
        WhiteStrikerFlag = 0;
        BlackStrikerFlag = 0;
        WhiteCoinCounter = 0;
        BlackCoinCounter = 0;
        MainPointQueenFlag = 0;
    }

        
    

    // Update is called once per frame
    void Update()
    {
        if (WhiteScore == 9 && MainPointQueenFlag == -1) //Queen with Black
        {
            SceneManager.LoadScene(3);
        }

        else if(WhiteScore == 10 ) //Queen with White
        {
            SceneManager.LoadScene(3);
        }

        else if (BlackScore == 9 && MainPointQueenFlag == 1) //Queen with White
        {
            SceneManager.LoadScene(4);
        }
        else if (BlackScore == 10) //Queen with Black
        {
            SceneManager.LoadScene(4);
        }

        score = GetComponent<Text>();
        score.text = "W = " + WhiteScore + "\nB = " + BlackScore;

    
    }
    //Attach to next turn button
    public void ChangeSign()
    {
        flag *= -1;
    }


}
