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
    [SerializeField] Image cameraView,cameraButton,controlCalitateButton;
    [SerializeField] TextMeshProUGUI currentCameraText;
    [SerializeField] string[] camerasTexts;
    int currentCamIndex;
    [SerializeField] TMP_InputField partNumberInput;
    //check 20s part variables
    [SerializeField] Animator checkQuality;
    float timer;
    bool checking;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        CamerePanel.SetActive(true);
        ControlCalitatePanel.SetActive(false);
        cameraButton.color = new Color32(53, 53, 53, 255);
        controlCalitateButton.color = new Color32(124, 124, 124, 255);
        currentCamIndex = 0;
        cameraView.sprite = cameras[currentCamIndex];
        currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex*2+1];
        checking = true;
        timer = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(checking)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            checkQuality.Play("check");
        }
        if(timer < 0)
        {
            checking = false;
        }
    }
    public void User()
    {
        manager.User();
    }
    public void ControlCalitate()
    {
        CamerePanel.SetActive(false);
        ControlCalitatePanel.SetActive(true);
        cameraButton.color = new Color32(124, 124, 124, 255);
        controlCalitateButton.color = new Color32(53, 53, 53, 255);
    }
    public void Camere()
    {
        CamerePanel.SetActive(true);
        ControlCalitatePanel.SetActive(false);
        cameraButton.color = new Color32(53, 53, 53, 255);
        controlCalitateButton.color = new Color32(124, 124, 124, 255);
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
    public void Check()
    {
        if (!checking)
        {
            checking = true;
            timer = 60;
            checkQuality.Play("uncheck");
        }
    }
    public void TrimiteRaport()
    {
        if (partNumberInput.text == "")
        {
            manager.RaportNetrimis();
        }
        else
        {
            manager.RaportTrimis();
            partNumberInput.text = "";
        }
    }
}
