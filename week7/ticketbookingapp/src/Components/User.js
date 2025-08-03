import React from 'react';
import FlightList from './FlightList';

function User({ onLogout }) {
    return (
        <div style={{ textAlign: 'center', padding: '20px' }}>
            <h2>Welcome User</h2>
            <FlightList />
            <button onClick={onLogout} style={{ marginTop: '20px' }}>Logout</button>
        </div>
    );
}

export default User;
