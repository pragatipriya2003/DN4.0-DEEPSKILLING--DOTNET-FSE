import React from 'react';

function FlightList() {
    const flights = [
        { id: 1, name: "Air India AI-202", price: 7500 },
        { id: 2, name: "IndiGo 6E-305", price: 6800 },
        { id: 3, name: "Vistara UK-811", price: 8200 }
    ];

    return (
        <div>
            <h3>Available Flights</h3>
            <ul>
                {flights.map(flight => (
                    <li key={flight.id}>
                        {flight.name} - ₹{flight.price}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default FlightList;
