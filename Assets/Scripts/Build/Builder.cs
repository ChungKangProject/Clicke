using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Developers.Structure;

public class Builder : MonoBehaviour
{
    private SpriteRenderer spriteRenderer = null;
    public BuildingType buildingType;


    public bool Load()
    {
        

        return true;
    }


    private void Awake ( )
    {
        spriteRenderer = GetComponent<SpriteRenderer> ( );
        spriteRenderer.enabled = false;
    }
}
