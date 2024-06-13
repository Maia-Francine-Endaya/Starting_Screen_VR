using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setText : MonoBehaviour
{
  public Text name;
  public Text status;
  public Text schedule;
  public Text physician;
  void Start()
  {
    //Set the details of the patient here, pull from database (?)
    name.text = "Teresa R. Brown";
    status.text = "Check In";
    schedule.text = "2:00 PM";
    physician.text = "Donnie York";
  }
}
