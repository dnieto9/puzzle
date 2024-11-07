using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class PuzzleManager : MonoBehaviour
{
    public Sprite[] images;
    private Piece[] pieces;
    private int ct ; 
    // Start is called before the first frame update
    void Start()
    {   ct = images.Length;
        
        for(int i = 0; i < ct;i++ ){
        //   pieces.Append(new Piece(images[i]));
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
