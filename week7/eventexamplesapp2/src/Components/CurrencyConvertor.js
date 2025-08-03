import React, { useState } from "react";

function CurrencyConvertor() {
    const [rupees, setRupees] = useState("");
    const [euros, setEuros] = useState("");

    // Conversion rate (example: 1 INR = 0.011 EUR)
    const conversionRate = 0.011;

    // Handle Submit Event
    const handleSubmit = (e) => {
        e.preventDefault(); // Prevent page reload
        if (!rupees || isNaN(rupees)) {
            alert("Please enter a valid number");
            return;
        }
        const converted = (parseFloat(rupees) * conversionRate).toFixed(2);
        setEuros(converted);
    };

    return (
        <div>
            <h2>Currency Convertor (INR → EUR)</h2>
            <form onSubmit={handleSubmit}>
                <input
                    type="text"
                    placeholder="Enter amount in INR"
                    value={rupees}
                    onChange={(e) => setRupees(e.target.value)}
                />
                <button type="submit">Convert</button>
            </form>

            {euros && <p>{rupees} INR = {euros} EUR</p>}
        </div>
    );
}

export default CurrencyConvertor;
