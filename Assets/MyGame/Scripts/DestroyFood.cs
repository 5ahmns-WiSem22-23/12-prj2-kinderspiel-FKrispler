using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    public bool spoonTouch = false;
    public GameObject vischlLize;

    //private void Start()
    //{
      //  vischlLize.SetActive(true);
    //}
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
            }

            if (collision.collider.CompareTag("Plate"))
            {
                Destroy(gameObject);
                spoonTouch = false;
                vischlLize.SetActive(true);
            }
        }

    }
}