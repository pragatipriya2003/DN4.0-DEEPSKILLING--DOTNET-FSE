// JavaScript source code
// src/Components/IndianPlayers.js
import React from "react";

function IndianPlayers() {
    // ✅ Step 1: Using Destructuring to separate Odd & Even players
    const teamPlayers = ["Virat", "Rohit", "KL Rahul", "Shami", "Bumrah", "Iyer"];
    const [odd1, even1, odd2, even2, odd3, even3] = teamPlayers;

    // ✅ Step 2: Declare two arrays and merge using Spread operator
    const T20Players = ["Virat", "Rohit", "Surya"];
    const RanjiTrophyPlayers = ["Pujara", "Rahane"];
    const allPlayers = [...T20Players, ...RanjiTrophyPlayers];

    return (
        <div>
            <h2>Odd Team Players</h2>
            <ul>
                <li>{odd1}</li>
                <li>{odd2}</li>
                <li>{odd3}</li>
            </ul>

            <h2>Even Team Players</h2>
            <ul>
                <li>{even1}</li>
                <li>{even2}</li>
                <li>{even3}</li>
            </ul>

            <h2>All Players (Merged Array)</h2>
            <ul>
                {allPlayers.map((player, index) => (
                    <li key={index}>{player}</li>
                ))}
            </ul>
        </div>
    );
}

export default IndianPlayers;

