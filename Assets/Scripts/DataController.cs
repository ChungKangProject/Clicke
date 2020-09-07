using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;


public class DataController : MonoBehaviour
{
    private static DataController instance;


    //껏을때에 playdate를 받아오는 함수 
    DateTime GetLastPlayDate()
    {
        if(!PlayerPrefs.HasKey("Time"))
        {
            return DateTime.Now;
        }

        string timeBinaryInString = PlayerPrefs.GetString("Time");
        long TimeBinaryInLong = Convert.ToInt64(timeBinaryInString);

        return DateTime.FromBinary(TimeBinaryInLong);
    }


    void UpdateLastPlayDate()
    {
       PlayerPrefs.SetString("Time", DateTime.Now.ToBinary().ToString());
    }

    //유니티종료될때 자동으로 실행되는 함수 
    private void OnApplicationQuit()
    {
        UpdateLastPlayDate();
    }


    //Single ton 
    public static DataController Instance
    {
        get {
            if (instance == null)
            {
                instance = FindObjectOfType<DataController>();

                if (instance == null)
                {
                    GameObject container = new GameObject("DataController");

                    instance = container.AddComponent<DataController>();
                }
            }
            return instance;
        }
    }

    private Itembutton[] itembuttons;



    public long gold
    {
        get
        {
            if(!PlayerPrefs.HasKey("Gold"))
            {
                return 0;
            }

            string tempGold = PlayerPrefs.GetString("Gold");
            return long.Parse(tempGold);
        } 
        set
        {
            PlayerPrefs.SetString("Gold", value.ToString()); 
        }
    }

    public int goldPerClick
    {
        get
        {
            return PlayerPrefs.GetInt("GoldPerClick");

        }
        set
        {
            PlayerPrefs.SetInt("GoldPerClick", value);
        }
    }

    public int timeAfterLastPlay
    {
        get
        {
            DateTime currentime = DateTime.Now;
            DateTime lastPlayDate = GetLastPlayDate();

            return (int)currentime.Subtract(lastPlayDate).TotalSeconds;
        }
    }

    //Load
    private void Awake()
    {

        itembuttons = FindObjectsOfType<Itembutton>();

    }

    private void Start()
    {
        gold += GetGoldperSec() * timeAfterLastPlay;
        InvokeRepeating("UpdateLastPlayDate", 0f, 5f);
    }


    public void LoadUpgradeButton(UpgradeButton upgradeButton)
    {
        string key = upgradeButton.upgradeName;

        upgradeButton.level = PlayerPrefs.GetInt(key + "_level", 1);
        upgradeButton.goldByUpgrade = PlayerPrefs.GetInt(key + "_goldbyUpgrade",upgradeButton.startGoldByUpgrade);
        upgradeButton.currentCost = PlayerPrefs.GetInt(key + "_cost", upgradeButton.StartCurrentCost);
    }

    public void SaveUpgradeButton(UpgradeButton upgradeButton)
    {
        string key = upgradeButton.upgradeName;


        PlayerPrefs.SetInt(key + "_level", upgradeButton.level);
        PlayerPrefs.SetInt(key + "_goldByUpgrade", upgradeButton.goldByUpgrade);
        PlayerPrefs.SetInt(key + "_cost", upgradeButton.currentCost);
    }


    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }


    public void SaveItemButton(Itembutton itembutton)
    {
        string key = itembutton.ItemName;
        string itembuttonkey = itembutton.goldpersecond.ToString();
        string itembuttoncoast = itembutton.currentcoast.ToString();


        PlayerPrefs.SetInt(key + "_level", itembutton.itemLevel);
        PlayerPrefs.SetString(key + "_cost", itembuttoncoast);
        PlayerPrefs.SetString(key + "_goldPerSec", itembuttonkey);

        if (itembutton.isPurchased == true)
        {
            PlayerPrefs.SetInt(key + "_isPurchased", 1);
        }
        else
        {
            PlayerPrefs.SetInt(key + "_isPurchased", 0);
        }
    }



    public void LoadItemButton(Itembutton itembutton)
    {
        string key = itembutton.ItemName;

        string strcurrentcoast = PlayerPrefs.GetString(key + "_cost", itembutton.currentcoast.ToString());
        string strgoldpersec = PlayerPrefs.GetString(key + "_goldPerSec", itembutton.goldpersecond.ToString());


        itembutton.itemLevel = PlayerPrefs.GetInt(key + "_level");
        itembutton.currentcoast = Convert.ToInt64(strcurrentcoast);
        itembutton.goldpersecond = Convert.ToInt64(strgoldpersec);

        if(PlayerPrefs.GetInt(key + "_isPurchased") == 1)
        {
            itembutton.isPurchased = true;
        }
        else
        {
            itembutton.isPurchased = false;
        }
    }

   


    public long GetGoldperSec()
    {
        long goldpersecond = 0;
        for(int i = 0; i  < itembuttons.Length; ++i)
        {
            if (itembuttons[i].isPurchased)
            {
                goldpersecond += itembuttons[i].goldpersecond;
            }
        }

        return goldpersecond;
    }

    
}
