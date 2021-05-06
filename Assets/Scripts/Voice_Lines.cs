using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice_Lines: MonoBehaviour{
  public AudioSource Doctor_Normal;
  public AudioSource Doctor_Odd;
  public AudioSource Doctor_Alien;
  public AudioSource Intercom_1;
  public AudioSource Intercom_2;
  public AudioSource Intercom_Alien;
  public AudioSource Heartbeat;
  public AudioSource Patient_in_Pain;
  public AudioSource Patient_Distorted;

  public void PlayIntercom_1() {
  Intercom_1.Play();
}
  public void PlayIntercom_2() {
  Intercom_2.Play();
}

  public void PlayIntercom_Alien() {
  Intercom_Alien.Play();
}

  public void PlayDoctor_Normal() {
  Doctor_Normal.Play();
}

  public void PlayDoctor_Odd() {
  Doctor_Odd.Play();
}

  public void PlayDoctor_Alien() {
  Doctor_Alien.Play();
}

  public void PlayPatient_in_Pain() {
  Patient_in_Pain.Play();
}

  public void PlayPatient_Distorted() {
  Patient_Distorted.Play();
}

  public void PlayHeartbeat() {
  Heartbeat.Play();
}

}
