// JavaScript source code
import React from "react";
import "./OfficeSpace.css"; // CSS for styling

function OfficeSpace() {
    // Heading
    const heading = <h1>🏢 Office Space Rental Portal</h1>;

    // Image attribute
    const imageURL = "https://via.placeholder.com/400x200?text=Office+Space";

    // Single office object
    const office = {
        name: "Tech Tower",
        rent: 55000,
        address: "MG Road, Bangalore"
    };

    // List of office spaces
    const officeList = [
        { name: "Tech Tower", rent: 55000, address: "MG Road, Bangalore" },
        { name: "Green Hub", rent: 65000, address: "Indiranagar, Bangalore" },
        { name: "Biz Park", rent: 45000, address: "Whitefield, Bangalore" }
    ];

    return (
        <div>
            {heading}

            {/* Image */}
            <img src={imageURL} alt="Office Space" />

            {/* Single office details */}
            <h2>Featured Office</h2>
            <p>
                <strong>Name:</strong> {office.name}
            </p>
            <p
                style={{
                    color: office.rent < 60000 ? "red" : "green"
                }}
            >
                <strong>Rent:</strong> ₹{office.rent}
            </p>
            <p>
                <strong>Address:</strong> {office.address}
            </p>

            <hr />

            {/* List of offices */}
            <h2>All Available Offices</h2>
            <ul>
                {officeList.map((item, index) => (
                    <li key={index}>
                        <strong>{item.name}</strong> - ₹
                        <span style={{ color: item.rent < 60000 ? "red" : "green" }}>
                            {item.rent}
                        </span>{" "}
                        - {item.address}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default OfficeSpace;

