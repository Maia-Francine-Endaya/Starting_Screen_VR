using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SubmitForm : MonoBehaviour
{
  public Button submitButton;
  public void submitForm()
  {
    Debug.Log("Form submitted");
    SceneManager.LoadScene("Starting Room");
  }
}
