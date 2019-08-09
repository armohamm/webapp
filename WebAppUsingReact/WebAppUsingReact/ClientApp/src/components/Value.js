import React, { Component } from 'react';
import AddValue from './AddValue'

export class Value extends Component {
    displayName = Value.name

    constructor(props) {
        super(props);
        this.state = { values: [], loading: true };
        this.addValue = this.addValue.bind(this);

        fetch('api/Values/')
            .then(response => response.json())
            .then(data => {
                this.setState({ values: data, loading: false });
            });
    }

    static renderForecastsTable(values) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Value</th>
                    </tr>
                </thead>
                <tbody>
                    {values.map(val =>
                        <tr key={val.id}>
                            <td>{val.id}</td>
                            <td>{val.value}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
    addValue = (val) => {
        fetch('api/values',
            {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(val.content)
            });

        fetch('api/Values/')
            .then(response => response.json())
            .then(data => {
                this.setState({ values: data, loading: false });
            });
    }
    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Value.renderForecastsTable(this.state.values);

        return (
            <div>
                <h1>My Values</h1>
                <p>This component demonstrates fetching data from values controller.</p>
                {contents}
                <AddValue addValue={this.addValue} />
            </div>
        );
    }
}
