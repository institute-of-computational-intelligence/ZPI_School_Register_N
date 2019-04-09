import React, { Component } from 'react';
import './Login.css';
import AuthService from './AuthService';
//import intl from 'react-intl-universal';
//// locale data
//const locales = {
//    "en-US": require('../../locales/en-US.js'),
//    "pl-pl": require('../../locales/pl-PL.js')
//};

class Login extends Component {
    constructor() {
        super();
        this.handleChange = this.handleChange.bind(this);
        this.handleFormSubmit = this.handleFormSubmit.bind(this);
        this.Auth = new AuthService();
    }
    state = { initDone: false }
    componentWillMount() {
        if (this.Auth.loggedIn())
            this.props.history.replace('/');
    }
    componentDidMount() {
        this.loadLocales();
    }

    loadLocales() {
        intl.init({
            currentLocale: 'pl-pl',
            locales
        })
            .then(() => {
                this.setState({ initDone: true });
            });
    }
    handleChange(e) {
        this.setState(
            {
                [e.target.name]: e.target.value
            }
        );
    }

    handleFormSubmit(e) {
        e.preventDefault();
        if (this.state.username !== "" && this.state.password !== "") {
            this.Auth.login(this.state.username, this.state.password)
                .then(() => {
                        this.props.history.replace('/');
                    })
                .catch(err => {
                    alert(err);
                });
        }
    }

    render() {
        return (this.state.initDone &&
            <div className="center">
                <div className="card">
                <h1>{intl.get('login_label')}</h1>
                    <form onSubmit={this.handleFormSubmit}>
                        <input
                            className="form-item"
                            placeholder={intl.get('username_goes_here')}
                            name="username"
                            type="text"
                            onChange={this.handleChange}
                        />
                        <input
                            className="form-item"
                            placeholder={intl.get('password_goes_here')}
                            name="password"
                            type="password"
                            onChange={this.handleChange}
                        />
                        <input
                            className="form-submit"
                            value={intl.get('login')}
                            type="submit"
                        />
                        <label className="" />
                    </form>
                </div>
            </div>
        );
    }


}

export default Login;