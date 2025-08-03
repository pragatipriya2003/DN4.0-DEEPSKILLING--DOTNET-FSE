// JavaScript source code
// src/Components/ListOfPlayers.js
import React from "react";

function ListOfPlayers() {
    // ✅ Step 1: Declare array with 11 players using ES6 map()
    const players = [
        { name: "Virat Kohli", score: 85 },
        { name: "Rohit Sharma", score: 45 },
        { name: "KL Rahul", score: 76 },
        { name: "Shreyas Iyer", score: 50 },
        { name: "Hardik Pandya", score: 95 },
        { name: "Ravindra Jadeja", score: 65 },
        { name: "Rishabh Pant", score: 88 },
        { name: "Bumrah", score: 30 },
        { name: "Shami", score: 72 },
        { name: "Ashwin", score: 68 },
        { name: "Surya Kumar", score: 90 }
    ];

    // ✅ Step 2: Filter players with scores < 70 using Arrow Function
    const lowScorers = players.filter(player => player.score < 70);

    return (
        <div>
            <h2>🏏 All Players</h2>
            <ul>
                {players.map((p, index) => (
                    <li key={index}>
                        {p.name} - {p.score}
                    </li>
                ))}
            </ul>

            <h3>Players with score below 70:</h3>
            <ul>
                {lowScorers.map((p, index) => (
                    <li key={index}>
                        {p.name} - {p.score}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default ListOfPlayers;

