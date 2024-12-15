using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MentenantaManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] GameObject ControlPanel, InventarPanel;
    [SerializeField] Image controlButton, inventarButton;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        ControlPanel.SetActive(true);
        InventarPanel.SetActive(false);
        controlButton.color = new Color32(53, 53, 53, 255);
        inventarButton.color = new Color32(124, 124, 124, 255);
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
}
