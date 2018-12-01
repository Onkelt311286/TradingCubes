using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, nextRoundButton;
    private int roundCounter = 0;
    public Text roundCounterText;

    private List<CubeController> selectionControllers = new List<CubeController>();

    private void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        m_YourThirdButton.onClick.AddListener(TaskOnClick);

        nextRoundButton.onClick.AddListener(nextRound);
    }

    private void nextRound()
    {
        roundCounter++;
        roundCounterText.text = "Runde: " + roundCounter.ToString();
        foreach (CubeController selectionController in selectionControllers)
        {
            selectionController.calculatePopulation();
        }
    }

    public void addSelectionController(CubeController selectionController)
    {
        selectionControllers.Add(selectionController);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}
