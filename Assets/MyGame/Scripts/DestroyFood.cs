using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    public bool spoonTouch = false;
    public GameObject vischlLize;
    public GameObject floorOBJ;
    public GameObject mouthOBJ;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Spoon"))
        {
            spoonTouch = true;
            vischlLize.SetActive(false);
        }



        if (spoonTouch == true)
        {
            if (collision.collider.CompareTag("Mouth"))
            {
                Destroy(gameObject);
                spoonTouch = false;
                vischlLize.SetActive(true);
                mouthOBJ.SetActive(true);
                if (mouthOBJ.activeSelf)
                {
                    ScoreManager scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
                    scoreManager.MouthScore(1);
                    mouthOBJ.SetActive(false);
                }
            }

            if (collision.collider.CompareTag("Plate"))
            {
                Destroy(gameObject);
                spoonTouch = false;
                vischlLize.SetActive(true);
                floorOBJ.SetActive(true);
                if (floorOBJ.activeSelf)
                {
                    ScoreManager scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
                    scoreManager.AddScore(1);
                    floorOBJ.SetActive(false);
                }
            }
        }

    }
}