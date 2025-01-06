using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerPanel : MonoBehaviour
{
    Manager manager;
    [SerializeField] GameObject CamerePanel, DateProductiePanel,ComandaPanel;
    [SerializeField] Sprite[] cameras;
    [SerializeField] Image cameraView, cameraButton,dateProductieButton,comandaButton;
    [SerializeField] TextMeshProUGUI currentCameraText;
    [SerializeField] string[] camerasTexts;
    [SerializeField] TMP_InputField numarUnitati;
    int currentCamIndex,chartIndex;
    [SerializeField] Sprite[] charts;
    [SerializeField] Image chartImage;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        DateProductiePanel.SetActive(true);
        CamerePanel.SetActive(false);
        ComandaPanel.SetActive(false);
        dateProductieButton.color = new Color32(53, 53, 53, 255);
        cameraButton.color = new Color32(124, 124, 124, 255);
        comandaButton.color = new Color32(124,124,124,255);
        currentCamIndex = 0;
        cameraView.sprite = cameras[currentCamIndex];
        currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex * 2 + 1];
        chartIndex = 0;
        chartImage.sprite = charts[chartIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UrmatoareaCamera()
    {
        if (currentCamIndex < cameras.Length - 1)
        {
            currentCamIndex++;
            cameraView.sprite = cameras[currentCamIndex];
            currentCameraText.text = camerasTexts[currentCamIndex * 2] + "\n" + camerasTexts[currentCamIndex * 2 + 1];
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
    public void Camere()
    {
        CamerePanel.SetActive(true);
        DateProductiePanel.SetActive(false);
        ComandaPanel.SetActive(false);
        cameraButton.color = new Color32(53, 53, 53, 255);
        dateProductieButton.color = new Color32(124, 124, 124, 255);
        comandaButton.color = new Color32(124,124,124, 255);
    }
    public void DateProductie()
    {
        CamerePanel.SetActive(false);
        DateProductiePanel.SetActive(true);
        ComandaPanel.SetActive(false);
        cameraButton.color = new Color32(124, 124, 124, 255);
        dateProductieButton.color = new Color32(53, 53, 53, 255);
        comandaButton.color = new Color32(124, 124, 124, 255);
    }
    public void Comanda()
    {
        CamerePanel.SetActive(false);
        DateProductiePanel.SetActive(false);
        ComandaPanel.SetActive(true);
        cameraButton.color = new Color32(124, 124, 124, 255);
        dateProductieButton.color = new Color32(124, 124, 124, 255);
        comandaButton.color = new Color32(53, 53, 53, 255);
    }
    public void TrimiteComanda()
    {
        if(IsNumeric(numarUnitati.text) && int.Parse(numarUnitati.text) > 0)
        {
            numarUnitati.text = "";
            manager.ComandaTrimisa();
        }
        else
        {
            manager.ComandaGresita();
        }
    }
    bool IsNumeric(string input)
    {
        return int.TryParse(input, out _);
    }
    public void User()
    {
        manager.User();
    }
    public void Dreapta()
    {
        if(chartIndex<2)
        {
            chartIndex++;
        }
        else
        {
            chartIndex = 0;
        }
        chartImage.sprite = charts[chartIndex];
    }
    public void Stanga()
    {
        if(chartIndex>0)
        {
            chartIndex--;
        }
        else
        {
            chartIndex = 2;
        }
        chartImage.sprite = charts[chartIndex];
    }
}
