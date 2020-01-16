function attachEvents() {
    $('#submit').on('click',submit);
    $('#refresh').on('click',refresh);

    let messageElement = $('#messages');
    let url = 'https://messanger-d191d.firebaseio.com/messanger.json';

    function submit() {
        let author = $('#author').val();
        let content = $('#content').val();
        let data = {author,content,timestamp: Date.now()};
        console.log(data);
        console.log(JSON.stringify(data));
        $.post(url,JSON.stringify(data))
            .then(success)
            .catch(error);

        function success() {
            messageElement.append(`${data.author}: ${data.content}`);
        }
    }

    function refresh() {
        $.get(url)
            .then(success)
            .catch(error);

        function success(resp) {
            messageElement.text('');
            for (let keyObj of Object.keys(resp)) {
                messageElement.append(`${resp[keyObj].author}: ${resp[keyObj].content}\n`);
            }
        }
    }

    function error() {
        messageElement.append($('<div>').text(`Invalid data`));
    }
}