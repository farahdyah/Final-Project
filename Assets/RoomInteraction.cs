using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInteraction : MonoBehaviour
{
    public GameObject CloseRoom; //Object yang akan di close atau Inactive 
    public GameObject LoadingPanel; //Object yang akan nutupin perpindahan object antara close room dan open room
    public GameObject OpenRoom; //Object yang akan di open atau Active 

    //Switch room dipanggil ketika player berinteraksi dengan pintu" yang bisa di Interaksi
    public void SwitchRoom()
    {
        StartCoroutine(SwitchingRoom());
    }

    IEnumerator SwitchingRoom()
    {
        LoadingPanel.SetActive(true); // Hanya bertugas untuk menutupi proses perpindahan dari Close room ke Open room 
        yield return new WaitForSeconds(0.5f); // Timer bebas  minimal 0.5f || 1f
        CloseRoom.SetActive(false); //Close room
        OpenRoom.SetActive(true); //Open room
        yield return new WaitForSeconds(0.5f);
        LoadingPanel.SetActive(false); // Tutup si loading biar keliatan Room yang sudah di open 
    }
}
