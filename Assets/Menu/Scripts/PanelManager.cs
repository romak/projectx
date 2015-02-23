using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class PanelManager : MonoBehaviour {

    public void OpenMenuPanel(GameObject panel) {
        panel.SetActive(true);
    }

    public void CloseMenuPanel(GameObject panel){
        panel.SetActive(false);
    }

}
