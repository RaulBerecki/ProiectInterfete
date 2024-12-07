using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentenantaManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] GameObject ControlPanel, InventarPanel;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        ControlPanel.SetActive(true);
        InventarPanel.SetActive(false);
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
    }
    public void Inventar()
    {
        ControlPanel.SetActive(false);
        InventarPanel.SetActive(true);
    }
}
