using TMPro;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public static UIManger instance;
    public TextMeshProUGUI text;
    public void UpdateUI(int HP, int MP)
    {
        text.text = $"HP: {HP}\nMP: {MP}";
    }
}
