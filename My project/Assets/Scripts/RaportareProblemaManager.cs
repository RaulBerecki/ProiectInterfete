using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaportareProblemaManager : MonoBehaviour
{
    [SerializeField] TMP_InputField inputProblema;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Close()
    {
        Destroy(this.gameObject);
    }
    public void Trimite()
    {
        if(inputProblema.text != ""){
            Destroy(this.gameObject);
        }
    }
}
