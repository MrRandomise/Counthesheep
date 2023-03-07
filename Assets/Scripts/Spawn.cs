using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Character;
    [SerializeField]
    private float TimeSpawn = 5;

    private void Start()
    {
        CreateChar();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(TimeSpawn);
            CreateChar();
        }
    }

    private void CreateChar()
    {
        Instantiate(Character, transform.position, Quaternion.identity);
    }
}
