function initializeTable() {
    $("#createLink").on('click', createCountry);
    addCountryToTable("Bulgaria", "Sofia");
    addCountryToTable("Germany", "Berlin");
    addCountryToTable("Russia", "Moscow");
    hideButtons();
    
    function addCountryToTable(country, capital) {
        let tr = $('<tr>')
            .append(`<td>${country}</td>`)
            .append(`<td>${capital}</td>`)
            .append($(`<td></td>`)
                .append($('<a href="#">[Up]</a>').on('click', moveUp))
                .append($('<a href="#">[Down]</a>').on('click', moveDown))
                .append($('<a href="#">[Delete]</a>').on('click', deleteRow))
            );



        $('#countriesTable').append(tr);
    }

    function createCountry() {
        let country = $('#newCountryText');
        let capital = $('#newCapitalText');
        addCountryToTable(country.val(), capital.val());
        country.val('');
        capital.val('');
        hideButtons();
    }

    function moveUp() {
        let row = $(this).closest('tr'); // OR $(this).parent().parent();
        let prevRow = row.prev();
        row.insertBefore(prevRow);
        hideButtons()
    }

    function moveDown() {
        let row = $(this).closest('tr'); // OR $(this).parent().parent();
        let nextRow = row.next();
        row.insertAfter(nextRow);
        hideButtons()
    }

    function deleteRow() {
        $(this).parent().parent().remove();
    }

    function hideButtons() {
        $('#countriesTable a').css('display', '');
        $('#countriesTable tr:eq(2) a:contains("Up")').css('display', 'none');
        $('#countriesTable tr:last a:contains("Down")').css('display', 'none');
    }
}
