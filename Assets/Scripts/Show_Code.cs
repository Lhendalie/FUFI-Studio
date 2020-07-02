using UnityEngine;
using UnityEngine.UI;

public class Show_Code : MonoBehaviour
{
    Text screenText;

    void Start()
    {
        screenText = gameObject.GetComponent<Text>();      
    }

    void Update()
    {
        if (Computer_Interaction.userCode != null)
        {
            screenText.text = Computer_Interaction.userCode.text;
        }
    }
}
