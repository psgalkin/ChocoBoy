using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUi : MonoBehaviour
{
    [SerializeField] private TMP_Text _chocolateText;
    [SerializeField] private TMP_Text _scumText;

    public void SetChocolate(float val)
    {
        _chocolateText.text =  $"Chocolates: {val.ToString()}";
    }
    
    public void SetScum(float val)
    {
        _scumText.text = $"Cleared: {val.ToString()}";
    }
}
