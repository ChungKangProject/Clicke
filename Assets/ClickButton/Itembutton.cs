using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itembutton : MonoBehaviour
{

    public Text ItemDisplayer;

    public string ItemName;

    public int itemLevel = 0;

    [HideInInspector]
    public long currentcoast;

    public long startcurrentcoast = 1;

    [HideInInspector]
    public long goldpersecond;

    public long startgoldpersecond = 0;

    public float coastpow = 3.14f;

    public float upgradepow = 1.07f;

    [HideInInspector]
    public bool isPurchased = false;

    private string coastNumber;

    private void Start()
    {

        //currentcoast = startcurrentcoast;
        //  goldpersecond = startgoldpersecond;

        DataController.Instance.LoadItemButton(this);
        StartCoroutine("AddGoldLoop");

        UpdateUI();
    }


    
    //Item 구매 유효성 검사 
    public void PurchaseItem()
    {
        if(DataController.Instance.gold >= currentcoast)
        {
            isPurchased = true;
            DataController.Instance.gold -= currentcoast;
            itemLevel++;

            UpdateItem();
            UpdateUI();

            DataController.Instance.SaveItemButton(this);
        }
    }


    //0.1초마다 GOLD 추가
    IEnumerator AddGoldLoop()
    {
        while(true)
        {
            if(isPurchased)
            {
                DataController.Instance.gold += goldpersecond;
            }

            yield return new WaitForSeconds(1.0f);
        }
    }


    //item에 능력을 update해주는 함수 
   public void UpdateItem()
    {
        goldpersecond = goldpersecond + startgoldpersecond * (int)Mathf.Pow(upgradepow, itemLevel);

        currentcoast = startcurrentcoast * (int)Mathf.Pow(coastpow, itemLevel);
    }

    //item ui를 보여주는 함수 
    public void UpdateUI()
    {

        string CoastMoney = checkcoast();

        ItemDisplayer.text = ItemName + "\n Level: " + itemLevel + "\n coast: " + CoastMoney + "\n Gold Persec:" + goldpersecond
        + "\n ispurchased: " + isPurchased;
    }


    
    //현재에 돈을 check하여 문자로 변환해준다.
    private string checkcoast()
    {

        coastNumber = currentcoast.ToString();

        if (coastNumber.Length <= (int)lebate.a)
        {
            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.b)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "a");   


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.c)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "b");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.d)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "c");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.e)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "d");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.f)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "e");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.g)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "f");

            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.h)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "g");


         
           return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.i)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "h");

            
            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.j)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "i");

            

            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.k)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "j");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.l)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "k");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.M)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "l");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.N)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "m");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.O)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "n");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.P)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "o");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.Q)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "p");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.R)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "q");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.S)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "r");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.T)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "s");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.U)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "t");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.V)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "u");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.W)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "v");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.X)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "w");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.Y)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "x");


            return coastNumber;
        }
        else if (coastNumber.Length <= (int)lebate.Z)
        {
            coastNumber = coastNumber.Substring(0, 5);
            coastNumber = coastNumber.Insert(2, ",");
            coastNumber = coastNumber.Insert(6, "y");


            return coastNumber;
        }
        
        return coastNumber;
    }


 public enum lebate
    {
        a = 5,
        b = 6,
        c = 7,
        d = 8,
        e = 9,
        f = 10,
        g = 11,
        h = 12,
        i = 13,
        j = 14,
        k = 15,
        l = 16,
        M = 17,
        N = 18,
        O = 19,
        P = 20,
        Q = 21,
        R = 22,
        S = 23,
        T = 24,
        U = 25,
        V = 26,
        W = 27,
        X = 28,
        Y = 29,
        Z = 30

    };
}
