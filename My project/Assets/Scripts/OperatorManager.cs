using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OperatorManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] Toggle[] listaEchipamente;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        for(int i = 0;i<listaEchipamente.Length;i++)
        {
            listaEchipamente[i].isOn = false;
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
    public void RaportareProblema()
    {
        bool check= false;
        for(int i = 0;i< listaEchipamente.Length; i++)
        {
            if (listaEchipamente[i].isOn==true)
            {
                check = true;
                break;
            }
        }
        if (check)
        {
            manager.RaportareProblema();
        }
    }
}
