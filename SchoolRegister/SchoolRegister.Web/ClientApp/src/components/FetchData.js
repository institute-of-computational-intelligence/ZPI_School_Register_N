import React, { Component } from 'react';
import AuthService from '../components/Authentication/AuthService';
const authService = new AuthService();
export class FetchData extends Component {
    displayName = FetchData.name
    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }
    componentDidMount() {
        if (authService.loggedIn())
            authService.fetch(`${authService.domain}/SampleData/WeatherForecasts`,
                {
                    method: 'GET'
                }, authService.getToken()).then(data => {
                    this.setState({ forecasts: data, loading: false });
                });
    }
    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderForecastsTable(this.state.forecasts);
        return (
            <div>
                <h1>Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
    static renderForecastsTable(forecasts) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Temp. (C)</th>
                        <th>Temp. (F)</th>
                        <th>Summary</th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(forecast =>
                        <tr key={forecast.dateFormatted}>
                            <td>{forecast.dateFormatted}</td>
                            <td>{forecast.temperatureC}</td>
                            <td>{forecast.temperatureF}</td>
                            <td>{forecast.summary}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
}