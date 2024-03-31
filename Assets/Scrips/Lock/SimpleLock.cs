using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleLock : MonoBehaviour
{
    public bool Interactable = true;
    public GameObject LockCanvas;
    public Text[] Text;

    public string Password;
    public string[] LockCharacterChoices;
    public int[] _lockCharacterNumber;
    private string _insertedPassword;
    void Start()
    {
        _lockCharacterNumber = new int[Password.Length];
        UpdateUI();
    }
    public void ChangeInsertedPassword(int number)
    {
        _lockCharacterNumber[number]++;
        if (_lockCharacterNumber[number] >= LockCharacterChoices[number].Length)
        {
            _lockCharacterNumber[number] = 0;
        }
        CheckPassword();
        UpdateUI();
    }
    public void CheckPassword()
    {
        int pass_len = Password.Length;
        _insertedPassword = "";
        for (int i = 0; i < pass_len; i++)
        {
            _insertedPassword += LockCharacterChoices[i][_lockCharacterNumber[i]].ToString();
        }
        if (Password == _insertedPassword)
        {
            Unlock();
        }
    }
    public void Unlock()
    {
        //Do Unlock thing
        Debug.Log("Unlocked");
        Interactable = false;
        StopInteract();
    }
    public void UpdateUI()
    {
        int len = Text.Length;
        for (int i = 0; i < len; i++)
        {
            Text[i].text = LockCharacterChoices[i][_lockCharacterNumber[i]].ToString();
        }
    }
    private void OnMouseDown()
    {
        Interact();
    }
    public void Interact()
    {
        if (Interactable)
            LockCanvas.SetActive(true);
    }
    public void StopInteract()
    {
        LockCanvas.SetActive(false);
    }
}
