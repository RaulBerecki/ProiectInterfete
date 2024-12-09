using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalitateManager : MonoBehaviour
{
    Manager manager;
    [SerializeField] GameObject CamerePanel,ControlCalitatePanel;
    [SerializeField] Sprite[] cameras;
    [SerializeField] Image cameraView;
    [SerializeField] TextMeshProUGUI currentCameraText;
    [SerializeField] string[] camerasTexts;
    int currentCamIndex;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        CamerePanel.SetActive(true);
        ControlCalitatePanel.SetActive(false);
        currentCamIndex = 0;
        cameraView.sprite = cameras[currentCamIndex];
        currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex*2+1];
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
    public void UrmatoareaCamera()
    {
        if(currentCamIndex<cameras.Length-1) 
        {
            currentCamIndex++;
            cameraView.sprite = cameras[currentCamIndex];
            currentCameraText.text = camerasTexts[currentCamIndex * 2] +"\n"+ camerasTexts[currentCamIndex * 2 + 1];
        }
        else
        {
            currentCamIndex = 0;
            cameraView.sprite = cameras[currentCamIndex];
            currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex * 2 + 1];
        }
    }
    public void CameraPrecedenta()
    {
        if (currentCamIndex > 0)
        {
            currentCamIndex--;
            cameraView.sprite = cameras[currentCamIndex];
            currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex * 2 + 1];
        }
        else
        {
            currentCamIndex = 5;
            cameraView.sprite = cameras[currentCamIndex];
            currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex * 2 + 1];
        }
    }
}
