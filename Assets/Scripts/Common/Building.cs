using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Developers.Structure;

public class Building : MonoBehaviour, IActor
{
    private SpriteRenderer spriteRenderer;
    
    
    public BuildingInfo buildingInfo;


    public void Load ( )
    {
        
    }


    private void Awake ( )
    {
        spriteRenderer = GetComponent<SpriteRenderer> ( );
    }
}
