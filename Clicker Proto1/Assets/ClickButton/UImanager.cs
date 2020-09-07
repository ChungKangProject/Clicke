using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UImanager : MonoBehaviour
{

    public Text GoldDisPlayer;

    public Text GoldPerClickDisplayer;

    public Text goldpersecDisplayer;
    
    
    

    List<string> MoneyName = new List<string>();
    private void Update()
    {
        GoldPerClickDisplayer.text = "GOLD DISPLAY: " + DataController.Instance.goldPerClick;

        goldpersecDisplayer.text = "GOLD PER SEC:" + DataController.Instance.GetGoldperSec();

    }

    private void Start()
    {
        StartCoroutine(GoldDisplay());
    }


    IEnumerator GoldDisplay()
    {
        while (true)
        {
            DataController.Instance.gold.ToString();
            

            if(DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.a)
            {
                GoldDisPlayer.text = "GOLD: " + DataController.Instance.gold;

                yield return null;
            }
           else if (   DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.b)
            {
              string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
              string te = testtext.Insert(2, ",");
              GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.a.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.c)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.b.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.d)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.c.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.e)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.d.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.f)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.e.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.g)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.f.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.h)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.g.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.i)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.h.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.j)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.i.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.k)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.j.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.l)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.k.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.M)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.l.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.N)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.M.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.O)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.N.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.P)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.O.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.Q)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.P.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.R)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.Q.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.S)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.R.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.T)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.S.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.U)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.T.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.V)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.U.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.W)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.V.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.X)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.W.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.Y)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.X.ToString();

                yield return null;
            }
            else if (DataController.Instance.gold.ToString().Length <= (int)Itembutton.lebate.Z)
            {
                string testtext = DataController.Instance.gold.ToString().Substring(0, 5);
                string te = testtext.Insert(2, ",");
                GoldDisPlayer.text = "GOLD: " + te + " " + Itembutton.lebate.Y.ToString();

                yield return null;
            }





            yield return new WaitForSeconds(0.1f);
        }
    }








    
    
}
