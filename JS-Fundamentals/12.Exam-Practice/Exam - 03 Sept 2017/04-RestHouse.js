function restHouse(rooms, guests) {

    for (let i = 0; i < 1; i++) {

        if (rooms[i].type === 'double-bedded' && !rooms[i].hasOwnProperty('guests')) {
            for (let g = 0; g < guests.length; g++) {
                if (guests[g].first.gender !== guests[g].second.gender) {
                    rooms[i].guests = guests[g];
                    guests.splice(g, 1);
                }

            }
        }
        if (rooms[i].type === 'triple') {
            if (!rooms[i].hasOwnProperty('guests')) {
                for (let g = 0; g < guests.length; g++) {
                    if (guests[g].first.gender === guests[g].second.gender) {
                        rooms[i].guests = guests[g];
                        guests.splice(g, 1);
                    }

                }

        }
        console.log(rooms[i].guests.first.name);
    }

    console.log('-'.repeat(25));
    console.log(rooms);
    console.log('-'.repeat(25));
    console.log(guests);
}


restHouse([ { number: '206', type: 'double-bedded' },
        { number: '311', type: 'triple' } ],
    [ { first: { name: 'Tanya Popova', gender: 'female', age: 24 },
        second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 } },
        { first: { name: 'Katerina Stefanova', gender: 'female', age: 23 },
            second: { name: 'Angel Nachev', gender: 'male', age: 22 } },
        { first: { name: 'Tatyana Germanova', gender: 'female', age: 23 },
            second: { name: 'Boryana Baeva', gender: 'female', age: 22 } } ]
);