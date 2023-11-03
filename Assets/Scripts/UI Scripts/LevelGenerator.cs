// using UnityEngine;
//
// public class LevelGenerator : MonoBehaviour
// {
//     public float tileSize = 1.0f; // Size of each tile in your grid.
//
//     int[,] levelMap =
//     {
//         {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
//         {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
//         {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
//         {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
//         {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
//         {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
//         {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
//         {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
//         {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
//         {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
//         {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
//         {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
//         {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
//         {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
//         {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
//     };
//
//     Vector3 characterPosition;
//     Vector3 characterGridPosition;
//     [SerializeField] private Transform pacStudent;
//
//     void Start()
//     {
//         // Set the character's initial grid position.
//         characterGridPosition = characterPosition; // Change to your desired starting grid position.
//         characterPosition = GridToWorldPosition(characterGridPosition);
//     }
//
//     public Vector3 GetCharacterGridPosition()
//     {
//         return characterGridPosition;
//     }
//
//     Vector3 GridToWorldPosition(Vector3 gridPosition)
//     {
//         // Convert grid position to world position based on the tileSize.
//         float x = gridPosition.x * tileSize;
//         float y = gridPosition.y * tileSize;
//         float z = 0; // Z-coordinate is set to zero for a 2D layout.
//
//         return new Vector3(x, y, z);
//     }
//
//     void getTileTypeAtNextPos(Vector3 position)
//     {
//         
//     }
//
//     bool IsWithinBounds(Vector3 gridPosition)
//     {
//         return gridPosition.x >= 0 && gridPosition.x < levelMap.GetLength(0) &&
//                gridPosition.y >= 0 && gridPosition.y < levelMap.GetLength(1);
//     }
// }