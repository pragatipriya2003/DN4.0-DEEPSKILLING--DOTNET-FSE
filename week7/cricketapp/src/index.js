// src/App.js
import React from "react";
import ListOfPlayers from "./Components/ListOfPlayers";
import IndianPlayers from "./Components/IndianPlayers";

function App() {
    // Change this to true/false to switch between components
    const flag = true;

    return (
        <div style={{ padding: "20px" }}>
            <h1>🏏 Cricket App</h1>
            {flag ? <ListOfPlayers /> : <IndianPlayers />}
        </div>
    );
}

export default App;
