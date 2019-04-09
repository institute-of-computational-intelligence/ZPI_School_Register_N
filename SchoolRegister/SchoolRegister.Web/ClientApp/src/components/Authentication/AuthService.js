import decode from 'jwt-decode';
import BaseService from '../../common/BaseService';

export default class AuthService extends BaseService {

    constructor(domain) {
        super(domain);
        this.login = this.login.bind(this);
        this.getProfile = this.getProfile.bind(this);
    }

    login(username, password) {
        var formData = new FormData();
        formData.append("login", username);
        formData.append("password", password);

        return this.fetch(`${this.domain}/Account/Login`,
            {
                body: formData,
                method: 'POST'
            }).then(res => {
            this.setToken(res.access_token);
            return Promise.resolve(res);
        });
    }

    loggedIn() {

        const token = this.getToken();
        return !!token && !this.isTokenExpired(token);
    }

    isTokenExpired(token) {
        try {
            const decoded = decode(token);
            if (decoded.exp < Date.now() / 1000) {
                return true;
            }
            else
                return false;
        }
        catch (err) {
            return false;
        }
    }

    setToken(idToken) {
        localStorage.setItem('id_token', idToken);
    }

    getToken() {
        return localStorage.getItem('id_token');
    }

    logout() {

        localStorage.removeItem('id_token');
    }

    getProfile() {
        return decode(this.getToken());
    }
}