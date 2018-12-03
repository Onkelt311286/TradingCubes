using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour{

    public int population;
    private Text populationText;
    private Text wareText;

    public Ware ware1;
    public Ware ware2;
    public Ware ware3;

    private GameController gameController;

    private void Start()
    {
        Text[] childTexts = this.gameObject.GetComponentsInChildren<Text>();
        foreach (Text childText in childTexts)
        {
            if (childText.name.Equals("PopulationText")) {
                populationText = childText;
                childText.text = population.ToString();
            }
            else if (childText.name.Equals("WarenListe")) {
                wareText = childText;
                childText.text =
                      ware1.name + ": " + ware1.menge + Environment.NewLine
                    + ware2.name + ": " + ware2.menge + Environment.NewLine
                    + ware3.name + ": " + ware3.menge;
            }
        }

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        gameController.addSelectionController(this);
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Selected: " + gameObject.name);
    }

    public void calculatePopulation(float randomFactor)
    {
        float tempPopulation = population * randomFactor;
        population = (int) tempPopulation;
        populationText.text = population.ToString();
    }
}
