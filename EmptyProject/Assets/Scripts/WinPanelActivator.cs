using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanelActivator : MonoBehaviour 
{
    [SerializeField] GameObject winPanel;
    public void TurnOffWinPanel()
    {
        winPanel.SetActive(false);
    }
    public void TurnOnWinPanel()
    {
        winPanel.SetActive(true);
    }
}
