using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Computer_Interaction : NetworkBehaviour
{
    public static Text userCode;

    public GameObject codePanel;

    void Start()
    {
        GameObject parent = GameObject.Find("Parent");
        codePanel = parent.transform.GetChild(0).gameObject;
    }

    private void OnTriggerStay(Collider other)
    {
        if (!isServer)
            return;

        if (other.CompareTag("computer"))
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                codePanel.SetActive(true);

                userCode = GameObject.Find("UserCode").GetComponent<Text>();

                Debug.Log(userCode.text);
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                codePanel.SetActive(false);
            }
        }       
    }
}
