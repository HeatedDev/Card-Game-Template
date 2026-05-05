
using System.Collections.Generic;


using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card_data> deck = new List<Card_data>();
    public List<Card_data> player_deck = new List<Card_data>();
    public List<Card_data> ai_deck = new List<Card_data>();
    public List<Card_data> player_hand = new List<Card_data>();
    public List<Card_data> ai_hand = new List<Card_data>();
    public List<Card_data> discard_pile = new List<Card_data>();
    public GameObject blank;
    public Vector3 player_hand_pos;
    public int player_health = 10;

    public Canvas canvas;

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Deal()
    {
        for (int i = 0; i < 2; i++)
        {
            //create a blanks card.
            GameObject top_card = Instantiate(blank, player_hand_pos, Quaternion.identity, canvas.transform);
        }
    }

    void Shuffle()
    {

    }

    void AI_Turn()
    {
        int random = Random.Range(0, ai_hand.Count);
        player_health = ai_hand[random].damage;

    }



    
}

/*
public class ButtonExample : MonoBehaviour
{
    using UnityEngine.UI;
    public Button myButton;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClicked);
    }

    void OnButtonClicked()
    {
        Debug.Log("Button was clicked!");
    }
}
*/