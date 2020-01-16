let users = (() => {
    function userById(userId) {
        const endpoint = `${userId}`;

        return remote.get('user', endpoint, 'kinvey');
    }
    return {
        userById
    }
})();