import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import withAuth from './components/Authentication/withAuth';
import { Subject } from "./components/Subject";
import { Chat } from "./components/Chat";
class App extends Component {
    displayName = App.name
    componentDidMount() {
    }

    render() {
        return (
            <div>
                <Layout history={this.props.history} user={this.props.user}>
                    <Route exact path='/' component={Subject} />
                    <Route exact path='/subject' component={Subject} />
                    <Route exact path='/chat' component={Chat} />
                </Layout>
            </div>
        );
    }
}
export default withAuth(App);