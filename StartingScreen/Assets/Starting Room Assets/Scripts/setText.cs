using System;
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
    setDetails("Bryant, Jay A.", "Check-In", "2:00PM", "Baker, Brian");
  }

  void setDetails(string patientName, string queueStatus, string appointment, string physicianName)
  {
    name.text = patientName;
    status.text = queueStatus;
    schedule.text = appointment;
    physician.text = physicianName;
  }
}
