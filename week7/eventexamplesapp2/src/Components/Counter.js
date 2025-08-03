import React, { useState } from "react";

function Counter() {
    const [count, setCount] = useState(0);

    // 1a. Increment function
    const increment = () => {
        setCount(count + 1);
    };

    // 1b. Say Hello message
    const sayHello = () => {
        alert("Hello! This is a static message.");
    };

    // 2. Say Welcome with argument
    const sayWelcome = (msg) => {
        alert(msg);
    };

    // 3. Synthetic event example
    const handleClick = () => {
        alert("I was clicked");
    };

    return (
        <div style={{ marginBottom: "40px" }}>
            <h2>Counter Example</h2>
            <p>Count: {count}</p>

            {/* Increase button - calls two functions */}
            <button onClick={() => { increment(); sayHello(); }}>
                Increment
            </button>

            {/* Decrease button */}
            <button onClick={() => setCount(count - 1)}>Decrement</button>

            {/* Welcome button with argument */}
            <button onClick={() => sayWelcome("Welcome to React Events!")}>
                Say Welcome
            </button>

            {/* Synthetic event */}
            <button onClick={handleClick}>OnPress</button>
        </div>
    );
}

export default Counter;
