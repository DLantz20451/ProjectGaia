using UnityEngine;
using System.Data;
using Mono.Data.Sqlite; // For using SQLite

public class DatabaseManager : MonoBehaviour
{
    // Player transform for access position
    [SerializeField]
    private Transform playerTransform;

    void Update()
    {
        // When pressed Q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Connect Database
            IDbConnection connection = ConnectDatabase("CoordinateDatabase");
            // Insert position values into table
            PushCommand(string.Format("INSERT INTO Coordinates (XMovement,YMovement,ZMovement) VALUES({0},{1},{2});", playerTransform.position.x, playerTransform.position.y, playerTransform.position.z), connection);
            // Close database
            connection.Close();
        }
    }

    // Connect database with database file name
    IDbConnection ConnectDatabase(string dbName)
    {
        // Search database file
        IDbConnection connection = new SqliteConnection(string.Format("URI=file:Assets/StreamingAssets/{0}.db", dbName));
        // Open database
        connection.Open();
        // Return database connection for using in another function
        return connection;
    }

    // Create new command on opened database
    void PushCommand(string commandString, IDbConnection connection)
    {
        // Create new command
        IDbCommand command = connection.CreateCommand();
        // Add your comment text (queries)
        command.CommandText = string.Format("{0}", commandString);
        // Execute command reader - execute command
        command.ExecuteReader();
    }
}
