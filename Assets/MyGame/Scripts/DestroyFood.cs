using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    public bool spoonTouch = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Spoon"))
        {
            spoonTouch = true;

        }



        if (spoonTouch == true)
        {
            if (collision.collider.CompareTag("Mouth"))
            {
                Destroy(gameObject);
                spoonTouch = false;
            }

            if (collision.collider.CompareTag("Plate"))
            {
                Destroy(gameObject);
                spoonTouch = false;
            }
        }

    }

}