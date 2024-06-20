using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
  //TO DO: Change the url to the appropriate websites
  public void OpenWebsite(string url = "https://www.youtube.com/watch?v=K52l9P19_2o&t=189s")
  {
    Application.OpenURL(url);
    Debug.Log("Pressed button");
  }
}
