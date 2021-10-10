import React from 'react';

class Nominations extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            error: null,
            isLoaded: false,
            nominations: []
        };
    }

    componentDidMount(){
        this.makeApiCall()
    }

    makeApiCall = () => {
        fetch("Access-Control-Allow-Origin, https://localhost:5000/api/Nominations", { credentials: "include", headers: { "Accept": "application/json", 'Content-Type': "application/json" }})
            .then(response => response.json())
            .then(
                (jsonifiedResponse) => {
                    this.setState({
                        isLoaded: true,
                        nominations: jsonifiedResponse.results
                    });
                })
                .catch((error) => {
                    this.setState({
                        isLoaded: true,
                        error
                    });
                });
            }

    render() {
        const { error, isLoaded, nominations } = this.state;
        if (error) {
            return <React.Fragment>Error: {error.message}</React.Fragment>;
        } else if (!isLoaded) {
            return <React.Fragment>Loading...</React.Fragment>;
        } else {
            return (
                <React.Fragment>
                    <h1>Nominations</h1>
                    <p>{nominations}</p>
                    {/* <ul>
                        {nominations.map((nomination, index) =>
                            <li key={index}>
                                <h3>{nomination.film}</h3>
                                <p>{nomination.nominee}</p>
                                <p>{nomination.year}</p>
                                <p>{nomination.category}</p>
                                <p>Winner?: {nomination.winner}</p>
                                <p>{nomination.notes}</p>
                            </li>
                        )}
                    </ul> */}
                </React.Fragment>
            );
        }
    }
}

export default Nominations;