using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
  //TO DO: Change the url to the appropriate websites
  public void OpenWebsite(string url)
  {
    Application.OpenURL(url);
    Debug.Log("Pressed button");
  }
}
