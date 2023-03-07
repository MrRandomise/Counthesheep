using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text time;
    private int Time;

    private void Start()
    {
        time = GetComponent<TMP_Text>();
        StartCoroutine("OnTimer");
    }

    IEnumerator OnTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            Time++;
            time.text = Time.ToString();
        }
    }
}
