using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public GameObject uiParent,loginPanel,operatorPanel,calitatePanel,mentenantaPanel;
    //LoginPanelVariables
    public TMP_InputField username, password;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime now = System.DateTime.Now;

        // Format it into a readable string
        string currentTime = now.ToString("HH:mm:ss");

        timeText.text = currentTime;
    }
    public void Operator()
    {
        GameObject panel=Instantiate(operatorPanel,uiParent.transform);
        panel.transform.parent = uiParent.transform;
    }
    public void Calitate()
    {
        GameObject panel = Instantiate(calitatePanel, uiParent.transform);
        panel.transform.parent = uiParent.transform;
    }
    public void Mentenanta()
    {
        GameObject panel = Instantiate(mentenantaPanel, uiParent.transform);
        panel.transform.parent = uiParent.transform;
    }
}
