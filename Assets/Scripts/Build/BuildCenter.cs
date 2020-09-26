using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildCenter : MonoBehaviour
{

   public int CenterLevel;

   public int soldierNumber;

   public int LevelupCenterCoast;

   public int SoldierBuycoast;

   public int CurrentProductionTime;

    public int CurrentUnitCoast = 100;
    

    public GameObject UIStatus;
    

   protected Dictionary<GameObject,int> SoldierCurrentNumber;

    // Start is called before the first frame update
    void Start()
    {
        SoldierCurrentNumber = new Dictionary<GameObject, int>();

      
    }
}
