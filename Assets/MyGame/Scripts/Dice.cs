using UnityEngine;

public class Dice : MonoBehaviour
{
    public GameObject[] diceFaces;
    public Vector2 spawnPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(1, 7);
            GameObject face = diceFaces[randomNumber - 1];
            Instantiate(face, spawnPosition, Quaternion.identity);
        }
    }
}
