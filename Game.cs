using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public int BaitRemaining;

    private int coins;

    public Text UICoins;
    public Text UIBaitRemaining;
    public Text UIResult;
    public Text UILevel;

    public GameObject ObjectCaught;

    //on click (to release object from hook?)
        //check caught object
        //check coins

    void Start()
    {
        coins = 0;
        BaitRemaining = 3;
        Setup();
    }

    void Update()
    {
        
    }

    public void Setup()
    {
        SetCoinsUI();
        SetBaitRemainingUI();
        HideResultUI();
    }

    void SetCoinsUI()
    {
        UICoins.text = "Coins: " + coins.ToString();
    }

    void SetBaitRemainingUI()
    {
        UIBaitRemaining.text = "Bait Remaining: " + BaitRemaining.ToString();
    }

    void HideResultUI()
    {
        UIResult.text = string.Empty;
    }

    void Win()
    {
        UIResult.text = "WIN";
    }

    void Lose()
    {
        UIResult.text = "LOSE";
    }

    public void CheckCaughtObject()
    {
        if (ObjectCaught.tag == "Fish")
        {
            coins += 10;
        }
        else if (ObjectCaught.tag == "Cup")
        {
            coins -= 10;
        }
        else if (ObjectCaught.tag == "Jellyfish")
        {
            BaitRemaining--;
        }
        else if (ObjectCaught.tag == "Blowfish")
        {
            coins -= 10;
            BaitRemaining--;
        }
    }

    public void CheckCoins()
    {
        if (BaitRemaining < 0)
        {
            Lose();
        }
       else if (BaitRemaining >= 0)
        {
            if (coins == 100)
            {
                //level complete
                //level up
            }
            else if (coins == 150)
            {
                //level complete
                //level up
            }
            else if (coins == 200)
            {
                //level complete
                //game over
                Win();
            }
        }
    }
}