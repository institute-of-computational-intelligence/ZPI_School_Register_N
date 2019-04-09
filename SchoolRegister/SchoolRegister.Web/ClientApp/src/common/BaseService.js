
export default class BaseService {
    constructor(domain) {
        var hostUrl = undefined;
        if (!process.env.NODE_ENV || process.env.NODE_ENV === 'development') {
            hostUrl = window.location.protocol +
                "//" +
                window.location.hostname +
                ":" +
                window.location.port +
                '/api';
        } else {
            hostUrl = process.env.PUBLIC_URL + '/api';
        }
        this.domain = domain || hostUrl;
        this.fetch = this.fetch.bind(this);

    }

    fetch(url, options, token) {
        const headers = {
            'Accept': 'text/plain'
        };

        if (token !== null) {
            headers['Authorization'] = 'Bearer ' + token;
        }

        return fetch(url,
            {
                headers,
                ...options
            })
            .then(this._checkStatus)
            .then(response => response.json())
            .catch(() => { });

    }

    _checkStatus(response) {
        // raises an error in case response status is not a success
        if (response.status >= 200 && response.status < 300) { // Success status lies between 200 to 300
            return response;
        } else {
            var error = new Error(response.statusText);
            error.response = response;
            response.text().then(function (err) {
                alert(err);
            });

            // throw error;
        }
    }
}