using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public delegate void Persistence();

    //public static event Persistence SaveGame;
    //public static event Persistence LoadGame;

    [SerializeField] private Image progressBar;
    [SerializeField] private Button button;
    [SerializeField] private Button saveButton;
    [SerializeField] private Button loadButton;

    [SerializeField] private TextMeshProUGUI characterName;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
