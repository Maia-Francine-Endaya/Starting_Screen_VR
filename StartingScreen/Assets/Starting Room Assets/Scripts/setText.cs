using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class setText : MonoBehaviour
{
  public TextMeshProUGUI name;
  public TextMeshProUGUI status;
  public TextMeshProUGUI schedule;
  public TextMeshProUGUI physician;


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
