class BookCollection {
    constructor(shelfGenre, room, capacity) {
        let roomError = room
        this.room = room
        if (this.room !== 'livingRoom' && this.room !== 'bedRoom' && this.room !== 'closet') {
            throw new Error(`Cannot have book shelf in ${roomError}`)
        }
        this.shelfGenre = shelfGenre;
        this.shelfCapacity = capacity;
        this.shelf = [];
    }

    addBook(bookName, bookAuthor, genre) {
        let book = {bookAuthor: bookAuthor, bookName: bookName, genre:genre};
        if (this.shelfCapacity > this.shelf.length) {
            this.shelf.push(book);
        }
        else {
            this.shelf.shift();
            this.shelf.push(book);
        }
        return this;
    }
    throwAwayBook(bookName) {
        for (let i = 0; i < this.shelf.length; i++) {
            let objBookName = this.shelf[i].bookName;
            if (objBookName === bookName) {
                this.shelf.splice(i, 1);
            }
        }
        return this;
    }
    showBooks(genre) {
        let search = '';
        let sorted = this.shelf
        sorted.sort(function(a,b) {
            if ( a.bookAuthor < b.bookAuthor )
                return -1;
            if ( a.bookAuthor > b.bookAuthor )
                return 1;
            return 0;
        });
        search += `Results for search "${genre}":\n`
        for (let i = 0; i < sorted.length; i++) {
            if (sorted[i].genre === genre) {
                let bookName = sorted[i].bookName;
                let bookAuthor = sorted[i].bookAuthor;
                search += `\uD83D\uDCD6 ${bookAuthor} - "${bookName}"\n`
            }
        }
        return search;
    }
    get shelfCondition() {
        return this.shelfCapacity - this.shelf.length;
    }

    toString() {
        let string = ''
        if (this.shelf.length > 0) {
            string += `"${this.shelfGenre}" shelf in ${this.room} contains:\n`
            for (let i = 0; i < this.shelf.length; i++) {
                let bookName = this.shelf[i].bookName;
                let bookAuthor = this.shelf[i].bookAuthor;
                string += `\uD83D\uDCD6 "${bookName}" - ${bookAuthor}\n`
            }
        }
        else {
            string += 'It\'s an empty shelf';
        }
        return string;
    }
}

let bedRoom = new BookCollection('Mixed', 'bedRoom', 5);
console.log(bedRoom.toString());


// let livingRoom = new BookCollection("Programming", "livingRoom", 5)
//     .addBook("Introduction to Programming with C#", "Svetlin Nakov")
//     .addBook("Introduction to Programming with Java", "Svetlin Nakov")
//     .addBook("Programming for .NET Framework", "Svetlin Nakov");
// console.log(livingRoom.toString());




