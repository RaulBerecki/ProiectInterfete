using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public GameObject uiParent,loginPanel,operatorPanel,calitatePanel,mentenantaPanel,usernamePanel,backgroundPanel;
    //LoginPanelVariables
    public GameObject RaportareProblemaPanel;
    public string usernameCurrent;
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
        backgroundPanel = Instantiate(operatorPanel,uiParent.transform);
        backgroundPanel.transform.parent = uiParent.transform;
        usernameCurrent = "Operator";
    }
    public void Calitate()
    {
        backgroundPanel = Instantiate(calitatePanel, uiParent.transform);
        backgroundPanel.transform.parent = uiParent.transform;
        usernameCurrent = "Calitate";
    }
    public void Mentenanta()
    {
        backgroundPanel = Instantiate(mentenantaPanel, uiParent.transform);
        backgroundPanel.transform.parent = uiParent.transform;
        usernameCurrent = "Mentenanta";
    }
    public void RaportareProblema()
    {
        GameObject panel = Instantiate(RaportareProblemaPanel, uiParent.transform);
        panel.transform.parent = uiParent.transform;
    }
    public void User()
    {
        GameObject panel = Instantiate(usernamePanel, uiParent.transform);
        panel.transform.parent = uiParent.transform;
    }
    public void Login()
    {
        Destroy(backgroundPanel);
        GameObject panel = Instantiate(loginPanel, uiParent.transform);
        panel.transform.parent = uiParent.transform;
    }
}
