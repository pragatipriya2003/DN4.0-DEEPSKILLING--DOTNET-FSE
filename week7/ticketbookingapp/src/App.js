import React, { useState } from 'react';
import Guest from './Components/Guest';
import User from './Components/User';

function App() {
    const [isLoggedIn, setIsLoggedIn] = useState(false);

    const handleLogin = () => setIsLoggedIn(true);
    const handleLogout = () => setIsLoggedIn(false);

    return (
        <div>
            <h1 style={{ textAlign: 'center', background: '#282c34', color: 'white', padding: '10px' }}>
                Ticket Booking App
            </h1>
            {isLoggedIn ? (
                <User onLogout={handleLogout} />
            ) : (
                <Guest onLogin={handleLogin} />
            )}
        </div>
    );
}

export default App;
