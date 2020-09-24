using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeScene : MonoBehaviour
{
    public GameObject FadeBlackobj;
    public GameObject FadeWhiteobj;

    public Image FadeBlack;

    public float FadeSceneSceond =0.5f;
    
    private SpriteRenderer UIimage;

    private float deltime = 0f;

    private float time = 0f;
    private float ftime = 1f;

    private bool startFadeto = false;

    private bool test = false;

    private SpriteRenderer ck;
    private SpriteRenderer ta;

    


    private void Start()
    {
      ck = FadeBlackobj.GetComponent<SpriteRenderer>();
      ta = FadeWhiteobj.GetComponent<SpriteRenderer>(); 
    }

    private void Update()
    {

        deltime += Time.deltaTime;


        if (deltime >= 2f && !startFadeto)
        {
            StartCoroutine(FadeToBlack());
            
        }

        if(startFadeto && !test)
        {
            StartCoroutine(FadeToWhite());
        }
    }


    IEnumerator FadeToBlack()
    {
        FadeBlack.gameObject.SetActive(true);
        Color alphaFadeBlack = FadeBlack.color;
        FadeBlackobj.gameObject.SetActive(true);
        FadeWhiteobj.gameObject.SetActive(false);
        
        while(alphaFadeBlack.a < 1f)
        {

            time += Time.deltaTime / ftime;
            alphaFadeBlack.a = Mathf.Lerp(0,1,time);
            FadeBlack.color = alphaFadeBlack;


            yield return new WaitForSeconds(2f);
        }

        startFadeto = true;
        yield return null;

    }

    IEnumerator FadeToWhite()
    {
        FadeBlackobj.gameObject.SetActive(false);
        FadeWhiteobj.gameObject.SetActive(true);
        Color alphaFadeBlack = FadeBlack.color;
        while (alphaFadeBlack.a >= 1f)
        {
            time += Time.deltaTime / ftime;
            alphaFadeBlack.a = Mathf.Lerp(1, 0, time);
            FadeBlack.color = alphaFadeBlack;


            yield return new WaitForSeconds(2f);
        }

        test = true;
        yield return null;
    }
    
}
