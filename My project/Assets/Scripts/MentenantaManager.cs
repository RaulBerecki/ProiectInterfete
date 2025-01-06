using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MentenantaManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] GameObject ControlPanel, InventarPanel;
    [SerializeField] Image controlButton, inventarButton;
    [SerializeField] string[] textMasiniUnelte;
    [SerializeField] TextMeshProUGUI[] textMasiniStatus;
    [SerializeField] Toggle[] selectorMasini;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        ControlPanel.SetActive(true);
        InventarPanel.SetActive(false);
        controlButton.color = new Color32(53, 53, 53, 255);
        inventarButton.color = new Color32(124, 124, 124, 255);
        for(int i = 0; i < textMasiniStatus.Length; i++)
        {
            textMasiniStatus[i].text = textMasiniUnelte[2*i] + textMasiniUnelte[2*i+1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void User()
    {
        manager.User();
    }
    public void Control() {
        ControlPanel.SetActive(true);
        InventarPanel.SetActive(false);
        controlButton.color = new Color32(53, 53, 53, 255);
        inventarButton.color = new Color32(124, 124, 124, 255);
    }
    public void Inventar()
    {
        ControlPanel.SetActive(false);
        InventarPanel.SetActive(true);
        controlButton.color = new Color32(124, 124, 124, 255);
        inventarButton.color = new Color32(53, 53, 53, 255);
    }
    public void Automat()
    {
        for (int i = 0; i < textMasiniStatus.Length; i++)
        {
            if (selectorMasini[i].isOn)
            {
                textMasiniStatus[i].text = textMasiniUnelte[2 * i] + "AUTOMAT";
                selectorMasini[i].isOn = false;
            }
        }
    }
    public void Manual()
    {
        bool ok = false;
        for (int i = 0; i < textMasiniStatus.Length; i++)
        {
            if (selectorMasini[i].isOn)
            {
                textMasiniStatus[i].text = textMasiniUnelte[2 * i] + "MANUAL";
                selectorMasini[i].isOn = false;
                ok = true;
            }
        }
        if (ok)
        {
            manager.Manual();
        }
    }
    public void Stop()
    {
        for (int i = 0; i < textMasiniStatus.Length; i++)
        {
            if (selectorMasini[i].isOn)
            {
                textMasiniStatus[i].text = textMasiniUnelte[2 * i] + "STOP";
                selectorMasini[i].isOn = false;
            }
        }
    }
}
