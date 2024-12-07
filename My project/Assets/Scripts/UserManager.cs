using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] TextMeshProUGUI usernameText;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        usernameText.text = manager.usernameCurrent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Close()
    {
        Destroy(this.gameObject);
    }
    public void Logout()
    {
        manager.Login();
        Destroy(this.gameObject);
    }
}
