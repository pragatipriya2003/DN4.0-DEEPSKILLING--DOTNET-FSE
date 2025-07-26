import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ name, status, trainer }) {
  const headingStyle = {
    color: status === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>Cohort Status: {status}</h3>
      <dl>
        <dt>Name</dt>
        <dd>{name}</dd>
        <dt>Trainer</dt>
        <dd>{trainer}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;
