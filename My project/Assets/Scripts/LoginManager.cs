using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public Manager manager;
    [SerializeField] TMP_InputField username, password;
    // Start is called before the first frame update
    void Start()
    {
        manager=GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Login()
    {
        if(username.text=="operator" && username.text==password.text)
        {
            manager.Operator();
            Destroy(this.gameObject);
        }
        else if(username.text=="calitate" && username.text == password.text)
        {
            manager.Calitate();
            Destroy(this.gameObject);
        }
        else if (username.text == "mentenanta" && username.text == password.text)
        {
            manager.Mentenanta();
            Destroy(this.gameObject);
        }
        else if (username.text == "manager" && username.text == password.text)
        {
            manager.ManagerPanel();
            Destroy(this.gameObject);
        }
    }
}
