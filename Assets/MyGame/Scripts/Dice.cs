using UnityEngine;

public class Dice : MonoBehaviour
{
    public GameObject[] diceFaces;
    public Transform[] spawnPoints;
    public GameObject vischlLize;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && vischlLize.activeSelf)
        {
                int randomNumber = Random.Range(0, diceFaces.Length);
                Vector3 spawnPos = spawnPoints[randomNumber].position;
                spawnPos.z = 0;
                Instantiate(diceFaces[randomNumber], spawnPos, Quaternion.identity);
            vischlLize.SetActive(false);
        }
    }
}
