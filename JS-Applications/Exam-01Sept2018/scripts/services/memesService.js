let meme = (() => {
    function getAllMemes() {
        const  endpoint = 'memes?query={}&sort={"_kmd.ect": -1}';

        return remote.get('appdata', endpoint, 'kinvey')
    }

    function getUserMeme(username) {
        const endpoint = `memes?query={"creator":"${username}"}&sort={"_kmd.ect": -1}`;

        return remote.get('appdata', endpoint, 'kinvey');
    }

    function getMemeById(memeId) {
        const endpoint = `meme?query={"_id":"${memeId}"}&sort={"_kmd.ect": -1}`;

        return remote.get('appdata', endpoint, 'kinvey');
    }

    function createMeme(title, description, imageUrl) {
        const data = {
            title: title,
            description: description,
            imageUrl: imageUrl,
        };

        return remote.post('appdata', 'memes', 'kinvey', data);
    }

    function deleteMeme(memeId) {
        const endpoint = `memes/${memeId}`;

        return remote.remove('appdata', endpoint, 'kinvey');
    }

    function editMeme(memeId, title, description, imageUrl) {
        const endpoint = `memes/${memeId}`;
        let data = { title, description, imageUrl };

        return remote.update('appdata', endpoint, 'kinvey', data);
    }

    return {
        getAllMemes,
        getUserMeme,
        getMemeById,
        createMeme,
        deleteMeme,
        editMeme
    }
})();