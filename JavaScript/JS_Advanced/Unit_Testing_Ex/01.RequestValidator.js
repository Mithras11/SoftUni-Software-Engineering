function solution(request) {

    let entries = Object.entries(request);

    let isValid = true;

    validate_Method(entries[0]);

    validate_uri(entries[1]);

    validate_version(entries[2]);

    validate_message(entries[3]);


    return request;



    function validate_Method(entry) {

        let methodValues = ['GET', 'POST', 'DELETE', 'CONNECT'];

        if (entry === undefined) {

            isValid = false;

        } else {

            let [name, val] = entry;
            if (name !== 'method' ||
                !methodValues.includes(val)) {

                isValid = false;
            };
        };

        if (!isValid) {

            throw new Error('Invalid request header: Invalid Method');
        };
    }


    function validate_uri(entry) {

        if (entry === undefined) {

            isValid = false;

        } else {

            let [name, val] = entry;

            if (name !== 'uri' || val === '') {
                isValid = false;
            }

            if (name === 'uri' && val !== '*' && val !== '') {

                let regexp = /^[a-zA-Z0-9.]*$/;
                isValid = regexp.test(val);
            };
        };

        if (!isValid) {
            throw new Error('Invalid request header: Invalid URI')
        };
    }

    function validate_version(entry) {

        let validVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];

        if (entry === undefined) {

            isValid = false;

        } else {

            let [name, val] = entry;

            if (name !== 'version' ||
                !validVersions.includes(val)) {
                isValid = false;
            };
        };

        if (!isValid) {
            throw new Error('Invalid request header: Invalid Version');

        };
    }

    function validate_message(entry) {

        if (entry === undefined) {

            isValid = false;

        } else {

            let [name, val] = entry;

            if (name !== 'message') {
                isValid = false;

            } else {

                let regexp = /^[^<>\\&'"]*$/;
                isValid = regexp.test(val);
            };

        };

        if (!isValid) {
            throw new Error('Invalid request header: Invalid Message')
        };
    }



}

const request1 = {
    method: 'POST',
    uri: 'home.bash',
    version: 'HTTP/2.0'
};

solution(request1);