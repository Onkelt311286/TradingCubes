using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Button nextRoundButton;
    private int roundCounter = 0;
    public Text roundCounterText;

    public float minRandomFactor = 0.8f;
    public float maxRandomFactor = 1.2f;

    private List<CubeController> selectionControllers = new List<CubeController>();

    private void Start()
    {
        nextRoundButton.onClick.AddListener(nextRound);
    }

    private void nextRound()
    {
        roundCounter++;
        roundCounterText.text = "Runde: " + roundCounter.ToString();
        float randomFactor = UnityEngine.Random.Range(minRandomFactor, maxRandomFactor);
        foreach (CubeController selectionController in selectionControllers)
            selectionController.calculatePopulation(randomFactor);
    }

    public void addSelectionController(CubeController selectionController)
    {
        selectionControllers.Add(selectionController);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}
