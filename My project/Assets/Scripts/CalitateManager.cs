using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalitateManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] GameObject CamerePanel,ControlCalitatePanel;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        CamerePanel.SetActive(true);
        ControlCalitatePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void User()
    {
        manager.User();
    }
    public void ControlCalitate()
    {
        CamerePanel.SetActive(false);
        ControlCalitatePanel.SetActive(true);
    }
    public void Camere()
    {
        CamerePanel.SetActive(true);
        ControlCalitatePanel.SetActive(false);
    }
}
