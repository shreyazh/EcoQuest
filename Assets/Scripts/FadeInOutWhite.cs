using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeInOutWhite : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool fadein = false;
    public bool fadeout = false;
    public float timeToFade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fadein == true) {
            if(canvasGroup.alpha < 1) {
                canvasGroup.alpha += timeToFade * Time.deltaTime;
                if(canvasGroup.alpha >= 1) {
                    fadein = false;
                }
            }
        }
        if(fadeout == true) {
            if(canvasGroup.alpha >= 0) {
                canvasGroup.alpha -= timeToFade * Time.deltaTime;
                if(canvasGroup.alpha == 0) {
                    fadeout = false;
                }
            }
        }
        
    }
    public void FadeIn()
    {
        fadein = true;
    }

    public void FadeOut()
    {
        fadeout = true;
    }



    public void OnTriggerEnter2D(Collider2D collidedObject) {
        if(collidedObject.name == "player") {
            SceneManager.LoadScene("FutureScene");
            SceneToFuture();
        }
    }
    private IEnumerator SceneToFuture() {
        FadeIn();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("FutureScene");
    }
}