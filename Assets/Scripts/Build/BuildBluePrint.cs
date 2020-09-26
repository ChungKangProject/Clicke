using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BuildBluePrint : MonoBehaviour
{

    public GameObject prefeb;
    public GameObject BuildTraining;
    public int coast;
  

    public int upgradeCoast;
    



    private void Start()
    {
    }


    public int GetSellAmount()
    {
        return coast / 2;
    }



    private void OnMouseDown()
    {
        if(PlayerManager.Instance.HasMoney >= coast)
        {
            PlayerManager.Instance.HasMoney -= coast;
            BuildTraining.SetActive(true);

            BuildTraining.transform.position = prefeb.transform.position;
            prefeb.gameObject.SetActive(false);
          
        }
    }
}
