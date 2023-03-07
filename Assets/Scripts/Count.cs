using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Count : MonoBehaviour
{
    private static TMP_Text CounterText;
    private static int Counter = 0;

    private void Start()
    {
        CounterText = GetComponent<TMP_Text>();
    }

    public static void ChangeCount()
    {
        Counter++;
        CounterText.text = Counter.ToString() + " прышков";
    }
}
