using UnityEngine;
using TMPro;
using Beetle.Count;

//script to show beetle counter onscreen

public class BeetleText : MonoBehaviour
{
    //variables for TMP text and beetlecount
    [SerializeField] TextMeshProUGUI beetleText;
    public int beetleCount;

    void Update()
    {
        //finds the beetleCount from the Score script
        beetleCount = FindObjectOfType<Score>().beetleCount;
        //adds the beetleCount to text box as a string
        beetleText.text = beetleCount.ToString();
    }
}
