using UnityEngine;
using System.Collections;

public class Gem : MonoBehaviour {
        
    // Update is called once per frame    
    void Update() {
        float x = transform.position.x;
        float y = transform.position.y;
        
        // Any falling to do?
        if (y > 0 && !Grid.gemAt(x, y-1)) {
            // Fall downwards
            while (y > 0 && !Grid.gemAt(x, y-1))
                --y;
            transform.position = new Vector2(x, y);
            
            // Solve possible matches
            Grid.solveMatches(Grid.matchesAt(x, y));
        }
    }
    
    public bool sameType(Gem other) {
        return GetComponent<SpriteRenderer>().sprite == other.GetComponent<SpriteRenderer>().sprite;
    }
}
