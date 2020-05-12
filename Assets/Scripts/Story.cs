using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    
    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextState();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Application.Quit();
        }

        textComponent.text = state.GetStateStory();
    }
}
