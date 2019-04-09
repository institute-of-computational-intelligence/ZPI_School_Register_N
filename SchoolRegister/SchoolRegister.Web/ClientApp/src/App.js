import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import withAuth from './components/Authentication/withAuth';
import FetchData from './components/FetchData';
//import '@progress/kendo-theme-bootstrap/dist/all.css';
import intl from 'react-intl-universal';
//const locales = {
//    "en-US": require('./locales/en-US.js'),
//    "pl-pl": require('./locales/pl-PL.js')
//};
class App extends Component {
    displayName = App.name
    state = { initDone: false }

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
    render() {
        return (this.state.initDone &&
            <div>
                <Layout history={this.props.history} user={this.props.user}>
                    <Route exact path='/' component={FetchData} />
                <Route exact path='/fetchdata' component={FetchData} />
                </Layout>

            </div>
        );
    }
}
export default withAuth(App);