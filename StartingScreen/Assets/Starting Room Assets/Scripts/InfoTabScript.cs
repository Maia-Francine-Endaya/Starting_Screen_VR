using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTabScript : MonoBehaviour
{
  public GameObject[] informationTabs;

  public void TurnOnTabs(int tab)
  {
    for (int i = 0; i < informationTabs.Length; i++)
    {
      informationTabs[i].SetActive(false);
    }
    informationTabs[tab - 1].SetActive(true);
  }
}
