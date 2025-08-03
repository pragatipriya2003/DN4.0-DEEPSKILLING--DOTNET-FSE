import React from "react";
import Counter from "./Components/Counter";
import CurrencyConvertor from "./Components/CurrencyConvertor";

function App() {
    return (
        <div style={{ padding: "20px" }}>
            <h1>React Event Examples App</h1>
            <Counter />
            <CurrencyConvertor />
        </div>
    );
}

export default App;
