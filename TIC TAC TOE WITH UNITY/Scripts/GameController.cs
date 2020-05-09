using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Text text;
    private Image image;
    public int turn;
    buttn setPlayer;

    public int[] field;
    public int sum;

    void Awake(){
    turn = 1;
    field = new int[9];
    }

    void Update()
    {
        GameObject btn1 = GameObject.Find("1");
        buttn turn1 = btn1.GetComponent<buttn>();
        field[0] = turn1.player;

        GameObject btn2 = GameObject.Find("2");
        buttn turn2 = btn2.GetComponent<buttn>();
        field[1] = turn2.player;

        GameObject btn3 = GameObject.Find("3");
        buttn turn3 = btn3.GetComponent<buttn>();
        field[2] = turn3.player;

        GameObject btn4 = GameObject.Find("4");
        buttn turn4 = btn4.GetComponent<buttn>();
        field[3] = turn4.player;

        GameObject btn5 = GameObject.Find("5");
        buttn turn5 = btn5.GetComponent<buttn>();
        field[4] = turn5.player;

        GameObject btn6 = GameObject.Find("6");
        buttn turn6 = btn6.GetComponent<buttn>();
        field[5] = turn6.player;

        GameObject btn7 = GameObject.Find("7");
        buttn turn7 = btn7.GetComponent<buttn>();
        field[6] = turn7.player;

        GameObject btn8 = GameObject.Find("8");
        buttn turn8 = btn8.GetComponent<buttn>();
        field[7] = turn8.player;

        GameObject btn9 = GameObject.Find("9");
        buttn turn9 = btn9.GetComponent<buttn>();
        field[8] = turn9.player;

        sum = field[0] + field[1] + field[2] + field[3] + field[4] + field[5] + field[6] + field[7] + field[8];
        if (sum == 2 || sum == 5 || sum == 8 || sum == 11)
        {
            turn = 2;
        }
        else
        {
            turn = 1;
        }

        
        if (field[0] == 1 && field[1] == 1 && field[2] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);
            

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }
        else if (field[3] == 1 && field[4] == 1 && field[5] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }
        else if (field[6] == 1 && field[7] == 1 && field[8] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }

        else if (field[0] == 1 && field[3] == 1 && field[6] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }
        else if (field[1] == 1 && field[4] == 1 && field[7] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }
        else if (field[2] == 1 && field[5] == 1 && field[8] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }
        else if (field[0] == 1 && field[4] == 1 && field[8] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }
        else if (field[2] == 1 && field[4] == 1 && field[6] == 1)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 2 wins!!";
        }

        else if (field[0] == 2 && field[1] == 2 && field[2] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

           GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }
        else if (field[3] == 2 && field[4] == 2 && field[5] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }
        else if (field[6] == 2 && field[7] == 2 && field[8] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }

        else if (field[0] == 2 && field[3] == 2 && field[6] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }
        else if (field[1] == 2 && field[4] == 2 && field[7] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }
        else if (field[2] == 2 && field[5] == 2 && field[8] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }
        else if (field[0] == 2 && field[4] == 2 && field[8] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!!";
        }
        else if (field[2] == 2 && field[4] == 2 && field[6] == 2)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Player 1 wins!";
        }
        else if (sum >= 14)
        {
            GameObject panel = GameObject.Find("All");
            panel.transform.gameObject.SetActive(false);

            GameObject myText = GameObject.Find("FinallText");
            text = myText.GetComponent<Text>();
            text.text = "Draw!";
        }

    }


}