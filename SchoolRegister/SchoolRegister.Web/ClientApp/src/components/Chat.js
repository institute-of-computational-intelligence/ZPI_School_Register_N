import React, { Component } from "react";
import * as signalR from "@aspnet/signalr";
import AuthService from '../components/Authentication/AuthService';
import { DropDownList } from '@progress/kendo-react-dropdowns';
import { Input } from '@progress/kendo-react-inputs';
const authService = new AuthService();

export class Chat extends Component {
    displayName = Chat.name

    constructor(props) {
        super(props);
        this.state = {
            hubConnection: null,
            chooseOptions: [
                { id: 1, name: "Users" },
                { id: 2, name: "Groups" }
            ],
            groups: [],
            users: [],
            message: {
                msgText: ""
            }
        };
        this.sendMessage = this.sendMessage.bind(this);
    }

    componentDidMount = () => {
        if (authService.loggedIn()) {
            authService.fetch(`${authService.domain}/Chat/GetStudents`,
                {
                    method: 'GET'
                },
                authService.getToken()).then(res => {
                    this.setState({ users: res });
                });

            authService.fetch(`${authService.domain}/Chat/GetGroups`,
                {
                    method: 'GET'
                },
                authService.getToken()).then(res => {
                    this.setState({
                        groups: res
                    });
                });
            const hubConnection = new signalR.HubConnectionBuilder()
                .withUrl("/chatHub", { accessTokenFactory: () => authService.getToken() })
                .build();
            hubConnection.start().catch(function (err) {
                return console.error(err.toString());
            });
            const localThis = this;
            hubConnection.on("ShowMessage", function (message) {
                const li = `<li>${localThis.encodeText(message.author)} : ${localThis.encodeText(message.msgText)}</li>`;
                const discussion = document.getElementById("discussion");
                discussion.innerHTML += li;
            });
            this.setState({
                hubConnection: hubConnection
            });
        }
    };

    onGroupsDropDownChange = (event) => {
        const edited = this.state.message;
        edited.group = {
            id: event.target.value.id,
            name: event.target.value.name
        };
        this.setState({
            message: edited
        });
    }
    onUsersDropDownChange = (event) => {
        const edited = this.state.message;
        edited.user = {
            id: event.target.value.id,
            name: event.target.value.name
        };
        this.setState({
            message: edited
        });
    }

    onChooseDropDownChange = (event) => {
        const edited = this.state.message;
        edited.choose = {
            id: event.target.value.id,
            name: event.target.value.name
        };
        this.setState({
            message: edited
        });
    }

    onInputChange = (event) => {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.props ? target.props.name : target.name;
        const edited = this.state.message;
        edited[name] = value;
        this.setState({
            message: edited
        });
    }
    encodeText= (text) =>{
        if (text !== undefined && text !== null) {
            text = text.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
            const encodedHtml = `<span>${text}</span>`;
            return encodedHtml;
        }
        return "";
    }

    sendMessage = () => {
        if (authService.loggedIn()) {
            let message = this.state.message;
            let hubMethod = "";
            if (message === undefined || message.choose === undefined)
                alert("Select users or group");
            else if (message.choose.id === 1) {
                message.recipientName = message.user.name;
                if (message.recipientName === "All") {
                    hubMethod = "SendMessageAll";
                } else {
                    hubMethod = "SendMessageToUser";
                }
            }
            else if (message.choose.id === 2) {
                message.recipientName = message.group.name;
                hubMethod = "SendMessageToGroup";
            }
            this.state.hubConnection
                .invoke(hubMethod, message)
                .catch(err => console.error(err));

            message.msgText = "";
            this.setState({ message: message });
        }
    };

    render() {
        return (
            <div>
                <h2>Chat</h2>
                <div className="row">
                    <div className="col-md-6 pull-left">
                        <section>
                            <div className="row">
                                <div className="form-group">
                                    <label className="col-md-3 control-label">Message : </label>
                                    <div className="col-md-9">
                                        <Input
                                            type="text"
                                            name="msgText"
                                            value={this.state.message.msgText || ''}
                                            onChange={this.onInputChange}
                                        />
                                    </div>
                                </div>
                            </div>
                            <div className="row">
                                <div className="form-group">
                                    <label className="col-md-3 control-label">Send to: </label>
                                    <div className="col-md-9">
                                        <div id="choose">
                                            <DropDownList
                                                data={this.state.chooseOptions}
                                                textField="name"
                                                dataItemKey="id"
                                                onChange={this.onChooseDropDownChange}
                                            />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="row">
                                <div className="form-group">
                                    <label className="col-md-3 control-label">Groups: </label>
                                    <div className="col-md-9">
                                        <div id="groups">
                                            <DropDownList
                                                data={this.state.groups}
                                                textField="name"
                                                dataItemKey="id"
                                                onChange={this.onGroupsDropDownChange}
                                            />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="row">
                                <div className="form-group">
                                    <label className="col-md-3 control-label">Users: </label>
                                    <div className="col-md-9">
                                        <div id="users">
                                            <DropDownList
                                                data={this.state.users}
                                                textField="name"
                                                dataItemKey="id"
                                                onChange={this.onUsersDropDownChange}
                                            />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="row">
                                <div className="form-group">
                                    <div className="col-md-9">
                                        <button
                                            className="btn btn-default"
                                            onClick={this.sendMessage}
                                        >
                                            Send
                                        </button>

                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                    <div className="col-md-6 pull-right">
                        <div className="form-group">
                            <div className="row">
                                <label className="col-md-2 control-label">Messages: </label>
                            </div>
                            <div className="row">
                                <ul id="discussion"></ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

export default Chat;