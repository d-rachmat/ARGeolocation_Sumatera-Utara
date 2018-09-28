using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class POItrigger : MonoBehaviour {
    public GameController gamecontroller;

    public GameObject panelInfo;

    public Image iconPOI;
    public Text locationName;
    public Text locationDistance;

    public string locationPOI;
    public string locationProvider;
    public string[] splitString;

    private void Start()
    {
        POIInitialized();
    }

    private void OnMouseDown()
    {
        if (panelInfo!=null)
        {
            panelInfo.SetActive(true);
        }        

        iconPOI.sprite = gameObject.GetComponentInChildren<Image>().sprite;
        locationName.text = transform.parent.name;
        splitString = locationPOI.Split(char.Parse(","));
        gamecontroller.latitude2 = float.Parse(splitString[1]);
        gamecontroller.longitude2 = float.Parse(splitString[0]);
    }

    void POIInitialized()
    {
        gamecontroller = GameObject.Find("WorldAlignmentKit").GetComponent<GameController>();

        panelInfo = gamecontroller.panelInfo;
        iconPOI = gamecontroller.iconPOI;
        locationName = gamecontroller.locationName;
        locationDistance = gamecontroller.locationDistance;
    }
}
