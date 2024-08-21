using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
  public void ToStartingRoom()
  {
    SceneManager.LoadScene("Starting Room");
  }

  public void ViewMedicalRecord()
  {
    SceneManager.LoadScene("Medical Record");
  }

  public void QuitApplication()
  {
    Application.Quit();
  }
}
