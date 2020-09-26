using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpereTraining : BuildCenter
{

    public Text LevelText;

    public Text TrainingUnitText;

    public GameObject SoldierObj;

    int SoldierIdx = 0;


    float tempUnitPosx = -6.32f;
    float Unitposx = -6.32f;
    float Unitposy = 2.37f;


    private int CenterUnitMax = 5;

    private int CurrentProductionUnit;

    private int posoffsetYidx = 0;



    private void Update()
    {
        LevelText.text = "Lv " + CenterLevel + "창병 훈련소";
        TrainingUnitText.text = CurrentProductionUnit + "/" + CenterUnitMax + "\n" + "훈련중";
    }



    private void OnMouseDown()
    {
        UIStatus.SetActive(true);
    }


    public void Close()
    {
        UIStatus.SetActive(false);
    }


    //유닛 생성 
    public void BuyUnit()
    {
        if(PlayerManager.Instance.HasMoney >= CurrentUnitCoast)
        {
            if(CenterUnitMax <= CurrentProductionUnit)
            {
                Debug.Log("더이상 유닛을 생성 할 수 없습니다.");
                return;
            }



            PlayerManager.Instance.HasMoney -= CurrentUnitCoast;

            GameObject SoldierPref = Instantiate(SoldierObj);
            SoldierPref.transform.position = new Vector3(Unitposx, Unitposy, 0);
            CurrentProductionUnit++;
            Unitposx += 1.5f;

            
            SoldierPref.transform.SetParent(UIStatus.transform);

            SoldierCurrentNumber.Add(SoldierPref, SoldierIdx);


            ++posoffsetYidx;
            ++SoldierIdx;

            if(posoffsetYidx == 5)
            {
                posoffsetYidx = 0;
                Unitposy -= 1f;
                Unitposx = tempUnitPosx;

            }

        }
    }


  public void BuildLevelUp()
    {
        if (PlayerManager.Instance.HasMoney >= LevelupCenterCoast)
        {
            PlayerManager.Instance.HasMoney -= LevelupCenterCoast;
            CenterUnitMax *= 2;
            CenterLevel++;



        }
    }

}
