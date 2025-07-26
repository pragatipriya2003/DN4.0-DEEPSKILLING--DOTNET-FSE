import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div className="App">
      <h2>Cohort Dashboard</h2>
      <CohortDetails name="React Bootcamp" trainer="John Doe" status="ongoing" />
      <CohortDetails name="Node.js Cohort" trainer="Jane Smith" status="completed" />
    </div>
  );
}

export default App;
