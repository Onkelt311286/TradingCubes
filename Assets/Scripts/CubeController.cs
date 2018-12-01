using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour{

    public int population;
    private Text populatiopnText;

    private GameController gameController;

    private void Start()
    {
        populatiopnText = this.gameObject.GetComponentInChildren<Text>();
        populatiopnText.text = population.ToString();

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        gameController.addSelectionController(this);
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Selected: " + gameObject.name);
        calculatePopulation();
    }

    public void calculatePopulation()
    {
        population--;
        populatiopnText.text = population.ToString();
    }
}
