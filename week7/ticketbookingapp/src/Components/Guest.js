import React from 'react';

function Guest({ onLogin }) {
    return (
        <div style={{ textAlign: 'center', padding: '20px' }}>
            <h2>Welcome Guest</h2>
            <p>Please log in to book tickets.</p>
            <button onClick={onLogin}>Login</button>
        </div>
    );
}

export default Guest;
