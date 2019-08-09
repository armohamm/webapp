import React, { Component } from 'react';

class AddValue extends Component {

    constructor(props) {
        super(props);
        this.state = { content: ''};
    }

    handleChange = (e) => {
        this.setState({
            content: e.target.value
        })
    }

    handleSubmit = (e) => {
        e.preventDefault();
        this.props.addValue(this.state);
        this.setState({
            content: ""
        })
    }
    render() {
        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <label> Add new value: </label>
                    <input type="text" onChange={this.handleChange} className="input" value={this.state.content} />
                </form>
            </div>
        )
    }
}

export default AddValue